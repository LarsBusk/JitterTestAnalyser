using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JitterTestAnalyser.Model
{
    [Table("TestSystem")]
    public partial class TestSystem
    {
        public int SystemID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string HardWare   { get; set; }
        public int RamSize { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateForImage { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
