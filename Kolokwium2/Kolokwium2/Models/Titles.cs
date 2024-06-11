using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("titles")]
public class Titles
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("Name")] 
    [MaxLength(100)]
    public string Name { get; set; }
    
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new List<CharacterTitles>();
}