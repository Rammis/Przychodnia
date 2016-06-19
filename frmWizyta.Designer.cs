namespace Przychodnia
{
    partial class frmWizyta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_nazwisko = new System.Windows.Forms.TextBox();
            this.textbox_stan = new System.Windows.Forms.TextBox();
            this.textbox_datarej = new System.Windows.Forms.TextBox();
            this.textbox_imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_opis = new System.Windows.Forms.TextBox();
            this.textbox_diagnoza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_wykaz_bf = new System.Windows.Forms.Button();
            this.button_pokaz_wiz = new System.Windows.Forms.Button();
            this.button_pokaz_bl = new System.Windows.Forms.Button();
            this.button_zlec_lab = new System.Windows.Forms.Button();
            this.button_zakoncz = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // textbox_nazwisko
            // 
            this.textbox_nazwisko.Location = new System.Drawing.Point(107, 68);
            this.textbox_nazwisko.Name = "textbox_nazwisko";
            this.textbox_nazwisko.ReadOnly = true;
            this.textbox_nazwisko.Size = new System.Drawing.Size(132, 20);
            this.textbox_nazwisko.TabIndex = 5;
            this.textbox_nazwisko.TabStop = false;
            // 
            // textbox_stan
            // 
            this.textbox_stan.Location = new System.Drawing.Point(392, 68);
            this.textbox_stan.Name = "textbox_stan";
            this.textbox_stan.ReadOnly = true;
            this.textbox_stan.Size = new System.Drawing.Size(132, 20);
            this.textbox_stan.TabIndex = 6;
            this.textbox_stan.TabStop = false;
            // 
            // textbox_datarej
            // 
            this.textbox_datarej.Location = new System.Drawing.Point(392, 23);
            this.textbox_datarej.Name = "textbox_datarej";
            this.textbox_datarej.ReadOnly = true;
            this.textbox_datarej.Size = new System.Drawing.Size(132, 20);
            this.textbox_datarej.TabIndex = 7;
            this.textbox_datarej.TabStop = false;
            this.textbox_datarej.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textbox_imie
            // 
            this.textbox_imie.Location = new System.Drawing.Point(107, 23);
            this.textbox_imie.Name = "textbox_imie";
            this.textbox_imie.ReadOnly = true;
            this.textbox_imie.Size = new System.Drawing.Size(132, 20);
            this.textbox_imie.TabIndex = 8;
            this.textbox_imie.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(297, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data_rej";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(324, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stan";
            // 
            // textbox_opis
            // 
            this.textbox_opis.Location = new System.Drawing.Point(107, 136);
            this.textbox_opis.Multiline = true;
            this.textbox_opis.Name = "textbox_opis";
            this.textbox_opis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_opis.Size = new System.Drawing.Size(132, 75);
            this.textbox_opis.TabIndex = 12;
            // 
            // textbox_diagnoza
            // 
            this.textbox_diagnoza.Location = new System.Drawing.Point(107, 249);
            this.textbox_diagnoza.Multiline = true;
            this.textbox_diagnoza.Name = "textbox_diagnoza";
            this.textbox_diagnoza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_diagnoza.Size = new System.Drawing.Size(132, 75);
            this.textbox_diagnoza.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Opis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Diagnoza";
            // 
            // button_wykaz_bf
            // 
            this.button_wykaz_bf.Location = new System.Drawing.Point(351, 116);
            this.button_wykaz_bf.Name = "button_wykaz_bf";
            this.button_wykaz_bf.Size = new System.Drawing.Size(173, 59);
            this.button_wykaz_bf.TabIndex = 16;
            this.button_wykaz_bf.Text = "Wykaz badań fizykalnych";
            this.button_wykaz_bf.UseVisualStyleBackColor = true;
            this.button_wykaz_bf.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_pokaz_wiz
            // 
            this.button_pokaz_wiz.Location = new System.Drawing.Point(351, 310);
            this.button_pokaz_wiz.Name = "button_pokaz_wiz";
            this.button_pokaz_wiz.Size = new System.Drawing.Size(173, 59);
            this.button_pokaz_wiz.TabIndex = 17;
            this.button_pokaz_wiz.Text = "Pokaż wizyty";
            this.button_pokaz_wiz.UseVisualStyleBackColor = true;
            // 
            // button_pokaz_bl
            // 
            this.button_pokaz_bl.Location = new System.Drawing.Point(351, 245);
            this.button_pokaz_bl.Name = "button_pokaz_bl";
            this.button_pokaz_bl.Size = new System.Drawing.Size(173, 59);
            this.button_pokaz_bl.TabIndex = 18;
            this.button_pokaz_bl.Text = "Pokaż badania";
            this.button_pokaz_bl.UseVisualStyleBackColor = true;
            // 
            // button_zlec_lab
            // 
            this.button_zlec_lab.Location = new System.Drawing.Point(351, 182);
            this.button_zlec_lab.Name = "button_zlec_lab";
            this.button_zlec_lab.Size = new System.Drawing.Size(173, 59);
            this.button_zlec_lab.TabIndex = 19;
            this.button_zlec_lab.Text = "Zleć badanie laboratoryjne";
            this.button_zlec_lab.UseVisualStyleBackColor = true;
            // 
            // button_zakoncz
            // 
            this.button_zakoncz.Location = new System.Drawing.Point(203, 397);
            this.button_zakoncz.Name = "button_zakoncz";
            this.button_zakoncz.Size = new System.Drawing.Size(120, 59);
            this.button_zakoncz.TabIndex = 20;
            this.button_zakoncz.Text = "Zakończ";
            this.button_zakoncz.UseVisualStyleBackColor = true;
            this.button_zakoncz.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(329, 397);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(120, 59);
            this.button_anuluj.TabIndex = 21;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_powrot
            // 
            this.button_powrot.Location = new System.Drawing.Point(455, 397);
            this.button_powrot.Name = "button_powrot";
            this.button_powrot.Size = new System.Drawing.Size(120, 59);
            this.button_powrot.TabIndex = 22;
            this.button_powrot.Text = "Powrót";
            this.button_powrot.UseVisualStyleBackColor = true;
            this.button_powrot.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmWizyta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 468);
            this.Controls.Add(this.button_powrot);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_zakoncz);
            this.Controls.Add(this.button_zlec_lab);
            this.Controls.Add(this.button_pokaz_bl);
            this.Controls.Add(this.button_pokaz_wiz);
            this.Controls.Add(this.button_wykaz_bf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_diagnoza);
            this.Controls.Add(this.textbox_opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_imie);
            this.Controls.Add(this.textbox_datarej);
            this.Controls.Add(this.textbox_stan);
            this.Controls.Add(this.textbox_nazwisko);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWizyta";
            this.Text = "Wizyta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LekarzB_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_nazwisko;
        private System.Windows.Forms.TextBox textbox_stan;
        private System.Windows.Forms.TextBox textbox_datarej;
        private System.Windows.Forms.TextBox textbox_imie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_opis;
        private System.Windows.Forms.TextBox textbox_diagnoza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_wykaz_bf;
        private System.Windows.Forms.Button button_pokaz_wiz;
        private System.Windows.Forms.Button button_pokaz_bl;
        private System.Windows.Forms.Button button_zlec_lab;
        private System.Windows.Forms.Button button_zakoncz;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Button button_powrot;
    }
}