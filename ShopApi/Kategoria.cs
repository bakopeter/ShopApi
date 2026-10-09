using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Kategoriak")] // Tábla nevének felülírása
public class Kategoria
{
    [Key] // Elsődleges kulcs
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
    public int Id { get; set; }

    [Required] // NOT NULL megszorítás
    [MaxLength(100)] // Maximális karakterszám
    public string Nev { get; set; } = string.Empty;

    // Navigációs tulajdonság a 1:N kapcsolathoz
    public ICollection<Termek> Termékek { get; set; } = new List<Termek>();
}

