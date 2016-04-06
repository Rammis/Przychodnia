namespace Przychodnia
{
    partial class Badania
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZleceniaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWykonaniaBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiBadania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wykonajButton = new System.Windows.Forms.Button();
            this.pokazButton = new System.Windows.Forms.Button();
            this.szukajButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.szukajButton);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 119);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 19;
            this.comboBox1.Items.AddRange(new object[] {
            "Zlecone",
            "Rozpoczęte",
            "Zakończone",
            "Anulowane"});
            this.comboBox1.Location = new System.Drawing.Point(400, 11);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "1";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(114, 84);
            this.textBox3.MaxLength = 15;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "11300965";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(114, 44);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Kwiatkowski";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(114, 8);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Jacek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(342, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(320, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data zlec.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Badania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBadania,
            this.kodBadania,
            this.nazwaBadania,
            this.statusBadania,
            this.dataZleceniaBadania,
            this.dataWykonaniaBadania,
            this.uwagiBadania});
            this.dataGridView1.Location = new System.Drawing.Point(15, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(718, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // IDBadania
            // 
            this.IDBadania.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IDBadania.DefaultCellStyle = dataGridViewCellStyle8;
            this.IDBadania.FillWeight = 90F;
            this.IDBadania.HeaderText = "ID Badania";
            this.IDBadania.Name = "IDBadania";
            this.IDBadania.ReadOnly = true;
            this.IDBadania.Width = 90;
            // 
            // kodBadania
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kodBadania.DefaultCellStyle = dataGridViewCellStyle9;
            this.kodBadania.FillWeight = 50F;
            this.kodBadania.HeaderText = "Kod";
            this.kodBadania.Name = "kodBadania";
            this.kodBadania.ReadOnly = true;
            this.kodBadania.Width = 50;
            // 
            // nazwaBadania
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nazwaBadania.DefaultCellStyle = dataGridViewCellStyle10;
            this.nazwaBadania.HeaderText = "Nazwa";
            this.nazwaBadania.Name = "nazwaBadania";
            this.nazwaBadania.ReadOnly = true;
            // 
            // statusBadania
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusBadania.DefaultCellStyle = dataGridViewCellStyle11;
            this.statusBadania.HeaderText = "Status";
            this.statusBadania.Name = "statusBadania";
            this.statusBadania.ReadOnly = true;
            // 
            // dataZleceniaBadania
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataZleceniaBadania.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataZleceniaBadania.HeaderText = "Data zlec.";
            this.dataZleceniaBadania.Name = "dataZleceniaBadania";
            this.dataZleceniaBadania.ReadOnly = true;
            // 
            // dataWykonaniaBadania
            // 
            this.dataWykonaniaBadania.HeaderText = "Data wyk.";
            this.dataWykonaniaBadania.Name = "dataWykonaniaBadania";
            this.dataWykonaniaBadania.ReadOnly = true;
            // 
            // uwagiBadania
            // 
            this.uwagiBadania.FillWeight = 150F;
            this.uwagiBadania.HeaderText = "Uwagi";
            this.uwagiBadania.Name = "uwagiBadania";
            this.uwagiBadania.ReadOnly = true;
            this.uwagiBadania.Width = 150;
            // 
            // wykonajButton
            // 
            this.wykonajButton.BackColor = System.Drawing.Color.ForestGreen;
            this.wykonajButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykonajButton.Location = new System.Drawing.Point(423, 393);
            this.wykonajButton.Name = "wykonajButton";
            this.wykonajButton.Size = new System.Drawing.Size(152, 42);
            this.wykonajButton.TabIndex = 2;
            this.wykonajButton.Text = "Wykonaj";
            this.wykonajButton.UseVisualStyleBackColor = false;
            // 
            // pokazButton
            // 
            this.pokazButton.BackColor = System.Drawing.Color.SteelBlue;
            this.pokazButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pokazButton.Location = new System.Drawing.Point(581, 393);
            this.pokazButton.Name = "pokazButton";
            this.pokazButton.Size = new System.Drawing.Size(152, 42);
            this.pokazButton.TabIndex = 3;
            this.pokazButton.Text = "Pokaż";
            this.pokazButton.UseVisualStyleBackColor = false;
            // 
            // szukajButton
            // 
            this.szukajButton.BackColor = System.Drawing.Color.DarkGray;
            this.szukajButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajButton.Location = new System.Drawing.Point(400, 84);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(119, 27);
            this.szukajButton.TabIndex = 8;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = false;
            // 
            // Badania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 442);
            this.Controls.Add(this.pokazButton);
            this.Controls.Add(this.wykonajButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Badania";
            this.Text = "Badania";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZleceniaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWykonaniaBadania;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiBadania;
        private System.Windows.Forms.Button wykonajButton;
        private System.Windows.Forms.Button pokazButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button szukajButton;
    }
}