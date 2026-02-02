using System;
using System.Collections.Generic;
using System.Data.Entity;
using JitterTestAnalyser.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitterTestAnalyser.Helpers
{
    internal class NewDbHelper
    {
        private DbContext jitterContext;

        private const string ConnectionString = "Data Source=bl-JitterData;Initial Catalog=JitterTestData;Integrated Security=True";

        public NewDbHelper()
        {
            jitterContext = new JitterTestData(ConnectionString);
        }

        public int GetDelayCount()
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            return context.Delays.Count();
        }

        public List<Model.TestSystem> GetTestSystems()
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            return context.TestSystem.ToList();
        }

        public List<string> GetNovaVersions()
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            return context.TestSetup.Select(ts => ts.NovaVersion).Distinct().ToList();
        }

        public List<string> GetMantaVersions()
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            return context.TestSetup.Select(ts => ts.MantaVersion).Distinct().ToList();
        }

        public int AddTestSetup(JitterTestResult testResult)
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            var testSetup = new Model.TestSetup
            {
                SystemID = testResult.TestSystem.SystemID,
                NovaVersion = testResult.NovaVersion,
                MantaVersion = testResult.MantaVersion,
                RawDataEnabled = testResult.RawDataEnabled,
                FODEnabled = testResult.FodEnabled,
                SurveilanceEnabled = testResult.SurveilanceEnabled,
                StatisticsEnabled = testResult.StatisticsEnabled,
                Product = testResult.Product,
                ConvSpeed = testResult.ConveyorSpeed,
                ImageLength = testResult.ImageLength,
                MeasureFrom = testResult.MeasureFrom,
                DataBaseSize = testResult.DataBaseSize,
                CsvFile = testResult.CsvFileName,
                OpcClient = testResult.OpcClient,
                NlcpPoints = testResult.NlcpPoints,
                Comment = testResult.Comment
            };
            context.TestSetup.Add(testSetup);
            context.SaveChanges();

            return testSetup.SetupID;
        }

        public void AddDelays(List<Delays> delays)
        {
            var context = jitterContext as JitterTestData;
            if (context == null)
            {
                throw new InvalidOperationException("DbContext is not of type JitterTestData.");
            }
            context.Delays.AddRange(delays);
            context.SaveChanges();
        }
    }
}
