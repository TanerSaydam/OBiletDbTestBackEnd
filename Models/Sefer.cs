using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models;

public sealed class Sefer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string GidilecekYer { get; set; }
    public string KalkisYeri { get; set; }
    public DateTime KalkisTarihi { get; set; }
    public DateTime VarisTarihi { get; set; }

    [ForeignKey("Otobus")]
    public int OtobusId { get; set; }
    public Otobus Otobus { get; set; }

    public ICollection<SeferSofor> SeferSofors { get; set; }
    public ICollection<SeferMuavin> SeferMuavins { get; set; }
    public ICollection<Bilet> Bilets { get; set; }
}
