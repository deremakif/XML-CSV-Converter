using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv_xml_formu
{
    class Export : Form1
    {
        public void ExportCSV(string sfdFileName, DataGridView dgv)
        {
           
        }

        public void ExportXML(string sfdFileName, DataGridView dgv)
        {
            DataSet dS = new DataSet("AddressInfo");
            var dt = new DataTable();
            dt.TableName = "City";
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.HeaderText);
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            dS.Tables.Add(dt);
            dS.WriteXml(sfdFileName);
        }


    }
}
