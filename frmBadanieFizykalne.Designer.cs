namespace Przychodnia
{
    partial class frmBadanieFizykalne
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
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_kod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_nazwa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_wynik = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_id_badania = new System.Windows.Forms.Label();
            this.textbox_id_badania = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kod";
            // 
            // textbox_kod
            // 
            this.textbox_kod.Location = new System.Drawing.Point(115, 62);
            this.textbox_kod.Name = "textbox_kod";
            this.textbox_kod.Size = new System.Drawing.Size(100, 20);
            this.textbox_kod.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwa";
            // 
            // textbox_nazwa
            // 
            this.textbox_nazwa.Location = new System.Drawing.Point(115, 102);
            this.textbox_nazwa.Name = "textbox_nazwa";
            this.textbox_nazwa.ReadOnly = true;
            this.textbox_nazwa.Size = new System.Drawing.Size(100, 20);
            this.textbox_nazwa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wynik";
            // 
            // textbox_wynik
            // 
            this.textbox_wynik.Location = new System.Drawing.Point(115, 147);
            this.textbox_wynik.Multiline = true;
            this.textbox_wynik.Name = "textbox_wynik";
            this.textbox_wynik.ReadOnly = true;
            this.textbox_wynik.Size = new System.Drawing.Size(100, 71);
            this.textbox_wynik.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_id_badania
            // 
            this.label_id_badania.AutoSize = true;
            this.label_id_badania.Location = new System.Drawing.Point(47, 30);
            this.label_id_badania.Name = "label_id_badania";
            this.label_id_badania.Size = new System.Drawing.Size(63, 13);
            this.label_id_badania.TabIndex = 10;
            this.label_id_badania.Text = "ID_Badania";
            // 
            // textbox_id_badania
            // 
            this.textbox_id_badania.Location = new System.Drawing.Point(115, 30);
            this.textbox_id_badania.Name = "textbox_id_badania";
            this.textbox_id_badania.Size = new System.Drawing.Size(100, 20);
            this.textbox_id_badania.TabIndex = 11;
            // 
            // frmBadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.textbox_id_badania);
            this.Controls.Add(this.label_id_badania);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox_wynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_nazwa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_kod);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBadanie";
            this.Text = "Nowe Badanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_kod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_nazwa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_wynik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_id_badania;
        private System.Windows.Forms.TextBox textbox_id_badania;
    }
}