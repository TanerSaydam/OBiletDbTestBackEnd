using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models;

public class SeferMuavin
{
    public int Id { get; set; }

    [ForeignKey("Sefer")]
    public int SeferId { get; set; }
    public Sefer Sefer { get; set; }

    [ForeignKey("Muavin")]
    public int MuavinId { get; set; }
    public Muavin Muavin { get; set; }
}
