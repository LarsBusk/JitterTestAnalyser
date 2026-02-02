using JitterTestAnalyser.Model;
using System;
using System.Collections.Generic;

namespace JitterTestAnalyser
{
    [Serializable]
    public class JitterTestResult
    {
        public Model.TestSystem TestSystem { get; set; }

        public string NovaVersion { get; set; }

        public string MantaVersion { get; set; }

        public bool RawDataEnabled { get; set; }

        public bool FodEnabled { get; set; }

        public bool SurveilanceEnabled { get; set; }

        public bool StatisticsEnabled { get; set; }

        public string Product { get; set; }

        public int ConveyorSpeed { get; set; }

        public int ImageLength { get; set; }

        public string MeasureFrom { get; set; }

        public int DataBaseSize { get; set; }

        public string CsvFileName { get; set; }

        public string OpcClient { get; set; }

        public int NlcpPoints { get; set; }

        public string Comment { get; set; }

        public List<Delays> Delays { get; set; }

        public JitterTestResult()
        {
            this.Delays = new List<Delays>();
        }
    }
}
