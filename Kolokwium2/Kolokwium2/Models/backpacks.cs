using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;

[PrimaryKey(nameof(CharacterId), nameof(ItemId))]

public class backpacks
{

    public int CharacterId { get; set; }
    
    [ForeignKey(nameof(CharacterId))]
    public Characters Characters { get; set; }

    public int ItemId { get; set; }
    [ForeignKey(nameof(ItemId))]
    public Items Items { get; set; }

    public int Amount { get; set; }

}