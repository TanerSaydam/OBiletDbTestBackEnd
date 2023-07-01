using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models;

public sealed class Sefer
{
    public int Id { get; set; }
    public string Name { get; set; }    

    [ForeignKey("Otobus")]
    public int OtobusId { get; set; }
    public Otobus Otobus { get; set; }

    public ICollection<SeferSofor> SeferSofors { get; set; }
    public ICollection<SeferMuavin> SeferMuavins { get; set; }
    public ICollection<Bilet> Bilets { get; set; }
    public ICollection<Durak> Duraks { get; set; }
}
