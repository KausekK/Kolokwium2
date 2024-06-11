using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Characters
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(120)]
    public string LastName { get; set; }
    
    [Required]
    public int CurrentWeight { get; set; }
    [Required]
    public int MaxWeight { get; set; }
    public ICollection<backpacks> Backpacks { get; set; }
    public ICollection<CharactersTitles> Titles { get; set; }

}