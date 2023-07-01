using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models;

public sealed class Bilet
{
    public int Id { get; set; }
    public string BiletNumarasi { get; set; } //GQ1235
    public int KoltukNumarasi { get; set; }

    [ForeignKey("Yolcu")]
    public int YolcuId { get; set; }
    public Yolcu Yolcu { get; set;}

    [ForeignKey("Sefer")]
    public int SeferId { get; set; }
    public Sefer Sefer { get; set; }
}
