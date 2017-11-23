using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitterTestAnalyser
{
  [Serializable]
  public class JitterTestResult 
  {
    public GetTestSystemsResult TestSystem { get; set; }

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

    public List<SampleDelay> Delays { get; set; }

    public JitterTestResult()
    {
      this.Delays = new List<SampleDelay>();
    }
  }

  public class SampleDelay
  {
    public DateTime TimeStamp { get; set; }

    public int Delay { get; set; }

    public int SampleId { get; set; }

    public SampleDelay(string line)
    {
      string[] elements = line.Split(';');

      this.TimeStamp = DateTime.Parse(elements[0]);
      this.SampleId = int.Parse(elements[1]);
      this.Delay = int.Parse(elements[2]);
    }
  }
}
