using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using JitterTestAnalyser.Helpers;
using JitterTestAnalyser.Model;

namespace JitterTestAnalyser
{
    public class FileHelper
    {
        public IEnumerable<Delays> ReadFromFile(JitterTestResult jitterTestResult, int newSetupId)
        {
            List<string> lines = File.ReadAllLines(jitterTestResult.CsvFileName).ToList();
            lines.RemoveAll(e => e.Contains("DateTime"));
            var systemId = jitterTestResult.TestSystem.SystemID;
            return lines.Select(e => NewDelay(e, systemId, newSetupId));
        }

        public void SaveToXml(JitterTestResult result, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(JitterTestResult));

            using (XmlWriter writer = XmlWriter.Create(path))
            {
                serializer.Serialize(writer, result);
                writer.Flush();
            }
        }

        private Delays NewDelay(string line, int systemId, int setupId)
        {
            var parts = line.Split(';');
            
            var delays = new Delays 
            { 
                Timestamp = DateTime.Parse(parts[0]), 
                SampleId = int.Parse(parts[1]),
                Delay = int.Parse(parts[2]),
                SystemID = systemId,
                SetupID = setupId
            };
            
            return delays;
        }


    }
}
