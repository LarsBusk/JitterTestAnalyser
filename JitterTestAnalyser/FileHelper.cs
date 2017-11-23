using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
//using MongoDB.Bson.IO;
//using MongoDB.Bson.Serialization;

namespace JitterTestAnalyser
{
  public class FileHelper
  {
    public List<SampleDelay> Delays { get; set; }

    public IEnumerable<SampleDelay> ReadFromFile(string path)
    {
      try
      {
        List<string> lines = File.ReadAllLines(path).ToList();

        lines.RemoveAll(e => e.Contains("DateTime"));

        return lines.Select(e => new SampleDelay(e));
      }
      catch (Exception e)
      {
        Exception inner = e.InnerException ?? new Exception();
        new ErrorForm(e.Message, inner.Message).ShowDialog();
      }

      return new List<SampleDelay>();
    }

    public void SaveToXml(JitterTestResult result, string path)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(JitterTestResult));

      using (XmlWriter writer = XmlWriter.Create(path) )
      {
        serializer.Serialize(writer, result);
        writer.Flush();
      }
    }

   /* public void SaveToBson(JitterTestResult result, string path)
    {
      Stream stream = new FileStream(path, FileMode.Create);
      using (BsonWriter writer = new BsonBinaryWriter(stream))
      {
        BsonSerializer.Serialize(writer, typeof (JitterTestResult));
        writer.Flush();
      }
      
    }*/
  }
}
