using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace csv_xml_formu
{
    class Import : Form1
    {
        public object ImportFile(string FileName)
        {
            DataGridView dgv = new DataGridView();
            if (String.Equals(Path.GetExtension(FileName), ".xml", StringComparison.OrdinalIgnoreCase))
            {                
                DataSet dataSet = new DataSet();       
                dataSet.ReadXml(FileName);
                int i = dataSet.Tables.Count;
                if (i < 2)
                {
                    dgv.DataSource = dataSet.Tables[0];
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    XElement xe = XElement.Load(FileName);
                    IEnumerable<XElement> City = xe.Elements();
                    string[] tmpfile;
                    tmpfile = new string[100];
                    for (int num = 0; num < 1; num++)
                    {
                        tmpfile[num] = string.Format(@"C:\Users\mehmet akif\tmp{0}.csv", num);
                        StreamWriter sw = new StreamWriter(tmpfile[num], true, Encoding.UTF8);
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
                        DataTable dt = new DataTable();
                        File.ReadLines(tmpfile[num]).Take(1)
                            .SelectMany(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                            .ToList()
                            .ForEach(x => dt.Columns.Add(x.Trim()));
                        File.ReadLines(tmpfile[num]).Skip(1)
                            .Select(x => x.Split(','))
                            .ToList()
                            .ForEach(line => dt.Rows.Add(line));
                        dgv.DataSource = dt;
                    }
                }
            }
            else if (String.Equals(Path.GetExtension(FileName), ".csv", StringComparison.OrdinalIgnoreCase))
            {
                var dt = new DataTable();
                File.ReadLines(FileName).Take(1)
                    .SelectMany(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    .ToList()
                    .ForEach(x => dt.Columns.Add(x.Trim()));
                File.ReadLines(FileName).Skip(1)
                    .Select(x => x.Split(','))
                    .ToList()
                    .ForEach(line => dt.Rows.Add(line));
                dgv.DataSource = dt;
            }
            else
            {
                MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML or CSV file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dgv.DataSource;
        }
    }
}