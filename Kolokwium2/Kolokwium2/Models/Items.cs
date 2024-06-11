using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

[Table("items")]
public class Items
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("Name")]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Column("Weight")]
    public int Weight { get; set; }

    public ICollection<Backpacks> Backpacks { get; set; } = new List<Backpacks>();
}