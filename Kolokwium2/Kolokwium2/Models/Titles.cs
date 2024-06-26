﻿using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Titles
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public ICollection<CharactersTitles> CharactersTitles { get; set; }

}