using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JitterTestAnalyser.Model
{
    [Table("Delays")]
    public partial class Delays
    {
        public int DelayId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Timestamp { get; set; }
        public int Delay { get; set; }
        public int SampleId { get; set; }
        public int SystemID { get; set; }
        public int SetupID { get; set; }
    }
}
