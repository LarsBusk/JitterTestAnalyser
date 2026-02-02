using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JitterTestAnalyser.Model
{
    [Table("TestSetup")]
    public partial class TestSetup
    {
        public int SetupID { get; set; }
        public int SystemID { get; set; }
        [StringLength(50)]
        public string NovaVersion { get; set; }
        [StringLength(50)]
        public string MantaVersion { get; set; }
        [StringLength(50)]
        public string Product { get; set; }
        public int ImageLength { get; set; }
        public bool RawDataEnabled { get; set; }
        public bool FODEnabled { get; set; }
        public bool SurveilanceEnabled { get; set; }
        public bool StatisticsEnabled { get; set; }
        [StringLength(50)]
        public string MeasureFrom { get; set; }
        public int ConvSpeed { get; set; }
        public int DataBaseSize { get; set; }
        [StringLength(20)]
        public string OpcClient { get; set; }
        public int NlcpPoints { get; set; }
        public string CsvFile { get; set; }
        public bool ExcludeFromSumery { get; set; } = false;
        public string Comment { get; set; }


    }
}
