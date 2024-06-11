using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[ApiController]
[Route("api/characters")]
public class Controller : ControllerBase
{
    private readonly Service _services;

    public Controller(Service service)
    {
        _services = service;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacter(int characterId)
    {
        var character = await _services.getCharacter(characterId);
        if (character == null)
        {
            return NotFound();
        }
        return Ok(character);
    }

    [HttpPost("{characterId}/backpacks")]
    public async Task<IActionResult> AddItemsToBackpack(int characterId, List<int> items)
    {
        try
        {
            var result = await _services.AddItemsToBackpack(characterId, items);
            return Ok(result);
        }
        catch (Exception)
        {
            return BadRequest("Blad podczas dodawania itemu do charakteru");
        }
    }
}