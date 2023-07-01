using System.ComponentModel.DataAnnotations.Schema;

namespace OBiletDbTestBackEnd.Models
{
    public sealed class SeferSofor
    {
        public int Id { get; set; }

        [ForeignKey("Sefer")]
        public int SeferId { get; set; }
        public Sefer Sefer { get; set; }

        [ForeignKey("Sofor")]
        public int SoforId { get; set; }
        public Sofor Sofor { get; set; }
    }
}
