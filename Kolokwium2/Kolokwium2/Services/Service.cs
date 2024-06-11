using Kolokwium2.Data;
using Kolokwium2.DTOs.response;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class Service
{
    private readonly Context _context;

    public Service(Context context)
    {
        _context = context;
    }

    public async Task<CharacterDTO> getCharacter(int id)
    {
        var character = await _context.Characters
            .Include(c => c.Backpacks)
                 .ThenInclude(b => b.Items)
            .Include(c => c.Titles)
                 .ThenInclude(ct => ct.titles)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (character == null)
        {
            return null;
        }

        return new CharacterDTO
        {
            firstName = character.FirstName,
            lastName = character.LastName,
            currentWeight = character.CurrentWeight,
            maxWeight = character.MaxWeight,
            backpackItems = character.Backpacks.Select(b => new BackpackItemDTO
            {
               itemName = b.Items.Name,
               itemWeight = b.Items.Weight,
               amount = b.Amount
            }).ToList(),
            titles = character.Titles.Select(t => new TitlesDTO
            {
               title = t.titles.Name,
               aquiredAt = t.AcquiredAt
            }).ToList()
        };
    }

    public async Task<List<BackpackItemDTO>> AddItemsToBackpack(int characterId, List<int> itemIds)
    {
        var character = await _context.Characters
            .Include(c => c.Backpacks)
                 .ThenInclude(b=>b.Items)
            .FirstOrDefaultAsync(c => c.Id == characterId);

        if (character == null)
            throw new Exception("Charakter nie zostal znaleziony");

        var items = await _context.Items.Where(i => itemIds.Contains(i.Id)).ToListAsync();

        if (items.Count != itemIds.Count)
            throw new Exception("Nie ma podanego itemu w bazie");

        int totalWeight = items.Sum(i => i.Weight);
        if (character.CurrentWeight + totalWeight > character.MaxWeight)
            throw new Exception("Za duza waga itemow");

        foreach (var item in items)
        {
            var backpackItem = character.Backpacks.FirstOrDefault(b => b.ItemId == item.Id);
            if (backpackItem != null)
            {
                backpackItem.Amount++;
            }
            else
            {
                character.Backpacks.Add(new backpacks
                {
                    ItemId = item.Id,
                    CharacterId = characterId,
                    Amount = 1
                });
            }
        }

        character.CurrentWeight += totalWeight;
        await _context.SaveChangesAsync();

       return character.Backpacks.Select(b => new BackpackItemDTO
        {
            itemName = b.Items.Name,
            itemWeight = b.Items.Weight,
            amount = b.Amount
        }).ToList();
    }
}