using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitterTestAnalyser
{
  public class DataBaseGetData
  {
    private DataBaseHelperDataContext context;

    public DataBaseGetData()
    {
      context = new DataBaseHelperDataContext();
    }

    public IEnumerable<string> GetNovaVersions()
    {
      //context = new DataBaseHelperDataContext();
      var se = context.TestSetups.GroupBy(t => t.NovaVersion).Select(g => g.First());
      var ver = se.Select(s => s.NovaVersion).OrderByDescending(t => t);
      return ver;
    }

    public IEnumerable<string> GetMantaVersions()
    {
      //context = new DataBaseHelperDataContext();
      var se = context.TestSetups.GroupBy(t => t.MantaVersion).Select(g => g.First());
      var ver = se.Select(s => s.MantaVersion);
      return ver;
    }


    public int AddTestSetup(JitterTestResult testResult
   )
    {
      return context.AddNewTestSetup(
        testResult.NovaVersion,
        testResult.MantaVersion,
        testResult.Product,
        testResult.ImageLength,
        testResult.RawDataEnabled,
        testResult.FodEnabled,
        testResult.SurveilanceEnabled,
        testResult.StatisticsEnabled,
        testResult.MeasureFrom,
        testResult.ConveyorSpeed,
        testResult.DataBaseSize,
        testResult.CsvFileName,
        testResult.TestSystem.SystemID,
        testResult.OpcClient,
        testResult.NlcpPoints,
        testResult.Comment);
    }

    public void AddDelay(DateTime timeStamp, int sampleId, int delay, int systemId, int setupId)
    {
      context.AddDelayValues(timeStamp, delay, sampleId, systemId, setupId);
    }

    public void DeleteSetupId(int setupID)
    {
      context.DeleteTestSetupID(setupID);
    }

    internal IQueryable GetTestSystems()
    {
      return context.GetTestSystems();
    }
  }

  public partial class GetTestSystemsResult
  {
    public override string ToString()
    {
      return this.Name;
    }
  }
}
