using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models;

public sealed class Durak
{
    public int Id { get; set; }
    public string SehirAdi { get; set; }
    public bool BaslangicDuragiMi { get; set; }
    public bool BitisDuragiMi { get; set; }
    public string KalkisYeri { get; set; }
    public DateTime KalkisTarihi { get; set; }
    public DateTime VarisTarihi { get; set; }

    [ForeignKey("Sefer")]
    public int SeferId { get; set; }
    public Sefer Sefer { get; set; }
}
