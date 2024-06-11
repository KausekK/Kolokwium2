using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;
[PrimaryKey(nameof(CharacterId), nameof(TitleId))]

public class CharactersTitles
{
    
    public int CharacterId { get; set; }
    
    [ForeignKey(nameof(CharacterId))]
    public Characters Characters { get; set; }
    
    public int TitleId { get; set; }
    
    [ForeignKey(nameof(TitleId))]
    public Titles titles { get; set; }

    public DateTime AcquiredAt { get; set; }


}