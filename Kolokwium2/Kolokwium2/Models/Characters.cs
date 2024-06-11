using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("characters")]
public class Characters
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("FirstName")]
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [Column("LastName")]
    [MaxLength(120)]
    public string LastName { get; set; }
    
    [Column("CurrentWei")]
    public int CurrentWei { get; set; }
    
    [Column("MaxWeight")]
    public int MaxWeight { get; set; }
    
    public ICollection<Backpacks> Backpacks { get; set; } = new List<Backpacks>();
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new List<CharacterTitles>();

}