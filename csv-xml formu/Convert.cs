using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace csv_xml_formu
{
    class Convert
    {
        public StringBuilder XmlToCsv(XElement xe)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<XElement> City = xe.Elements();
            StreamWriter sw = new StreamWriter(@"C:\Users\mehmet akif\Desktop\SAN TSG\Form\csv-xml formu\ConvertedCSV.csv", true, Encoding.UTF8);
            sw.Write("CityName,CityCode,DistrictName,ZipCode\n");
            foreach (var code in City)
            {
                string cityName = code.Attribute("name").Value;
                string cityCode = code.Attribute("code").Value;
                IEnumerable<XElement> District = code.Elements();
                foreach (var dname in District)
                {
                    string districtName = dname.Attribute("name").Value;
                    IEnumerable<XElement> Zip = dname.Elements();
                    foreach (var zcode in Zip)
                    {
                        string zipCode = zcode.Attribute("code").Value;
                        sw.Write(cityName + ",");
                        sw.Write(cityCode + ",");
                        sw.Write(districtName + ",");
                        sw.Write(zipCode + "\n");
                    }
                }
            }
            sw.Close();
            return sb;
        }
        public XElement CsvToXml(string st_csv)
        {
            var lines = File.ReadAllLines(st_csv);
            string[] headers = lines[0].Split(',').Select(x => x.Trim('\"')).ToArray();
            var xml = new XElement("AddressInfo", lines.Where((line, index) => index > 0).Select(line => new XElement("City", line.Split(',').Select((column, index) => new XElement(headers[index], column)))));
            return xml;
        }
    }
}
