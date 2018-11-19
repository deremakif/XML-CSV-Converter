using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Web;
using System.Xml;


namespace csv_xml_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Convert stsg = new Convert();
        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        public void btn_XmlToCsv_Click(object sender, EventArgs e)
        {
            XElement xelement = XElement.Load(@"C:\Users\mehmet akif\Desktop\SAN TSG\Form\csv-xml formu\ornek.xml");
            stsg.XmlToCsv(xelement);
        }
        private void btn_CsvToXml_Click(object sender, EventArgs e)
        {
            var xml = stsg.CsvToXml(@"C:\Users\mehmet akif\Desktop\SAN TSG\Form\csv-xml formu\ornek.csv");
            xml.Save(@"C:\Users\mehmet akif\Desktop\SAN TSG\Form\csv-xml formu\ConvertedXML.xml");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("CityName like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            }
            catch
            {
            }
        }
        Boolean lastSortedAscending = false;
        public static DataGridView DataGridView1 { get; private set; }
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lastSortedAscending = !lastSortedAscending;
            if (lastSortedAscending)
            {
                dataGridView1.Sort(dataGridView1.Columns[dataGridView1.SortedColumn.Name], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[dataGridView1.SortedColumn.Name], ListSortDirection.Ascending);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Import imp = new Import();
                textBox2.Text = ofd.FileName;
                dataGridView1.DataSource = imp.ImportFile(ofd.FileName);
            }
        }
        private void btn_ExportXml_Click(object sender, EventArgs e)
        {
            Export exp = new Export();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exp.ExportXML(sfd.FileName, dataGridView1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                textBox2.Text = sfd.FileName;
            }
        }
        private void btn_ExportCsv_Click_1(object sender, EventArgs e)
        {
            sfd.Filter = "CSV|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName, true, Encoding.UTF8);
                    var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                    sw.WriteLine(string.Join(",", headers.Select(column => "" + column.HeaderText + "").ToArray()));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sw.WriteLine(string.Join(",", cells.Select(cell => "" + cell.Value + "").ToArray()));
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                textBox2.Text = sfd.FileName;
            }
        }
    }
}
