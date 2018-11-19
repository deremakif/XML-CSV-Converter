namespace csv_xml_formu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_XmlToCsv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_CsvToXml = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ExportCsv = new System.Windows.Forms.Button();
            this.btn_ExportXml = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_XmlToCsv
            // 
            this.btn_XmlToCsv.Location = new System.Drawing.Point(6, 20);
            this.btn_XmlToCsv.Name = "btn_XmlToCsv";
            this.btn_XmlToCsv.Size = new System.Drawing.Size(75, 23);
            this.btn_XmlToCsv.TabIndex = 0;
            this.btn_XmlToCsv.Text = "XML to CSV";
            this.btn_XmlToCsv.UseVisualStyleBackColor = true;
            //this.btn_XmlToCsv.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 202);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            // 
            // btn_CsvToXml
            // 
            this.btn_CsvToXml.Location = new System.Drawing.Point(177, 30);
            this.btn_CsvToXml.Name = "btn_CsvToXml";
            this.btn_CsvToXml.Size = new System.Drawing.Size(75, 23);
            this.btn_CsvToXml.TabIndex = 3;
            this.btn_CsvToXml.Text = "CSV to XML";
            this.btn_CsvToXml.UseVisualStyleBackColor = true;
            //this.btn_CsvToXml.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By City:";
            // 
            // btn_ExportCsv
            // 
            this.btn_ExportCsv.Location = new System.Drawing.Point(576, 79);
            this.btn_ExportCsv.Name = "btn_ExportCsv";
            this.btn_ExportCsv.Size = new System.Drawing.Size(108, 23);
            this.btn_ExportCsv.TabIndex = 8;
            this.btn_ExportCsv.Text = "Export as CSV File";
            this.btn_ExportCsv.UseVisualStyleBackColor = true;
            this.btn_ExportCsv.Click += new System.EventHandler(this.btn_ExportCsv_Click_1);
            // 
            // btn_ExportXml
            // 
            this.btn_ExportXml.Location = new System.Drawing.Point(576, 109);
            this.btn_ExportXml.Name = "btn_ExportXml";
            this.btn_ExportXml.Size = new System.Drawing.Size(108, 23);
            this.btn_ExportXml.TabIndex = 9;
            this.btn_ExportXml.Text = "Export as XML File";
            this.btn_ExportXml.UseVisualStyleBackColor = true;
            this.btn_ExportXml.Click += new System.EventHandler(this.btn_ExportXml_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(89, 111);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFile.TabIndex = 10;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XmlToCsv);
            this.groupBox1.Location = new System.Drawing.Point(88, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_ExportXml);
            this.Controls.Add(this.btn_ExportCsv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_CsvToXml);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SAN TSG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XmlToCsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_CsvToXml;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExportCsv;
        private System.Windows.Forms.Button btn_ExportXml;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

