namespace AvangersDietApp.UI
{
    partial class FoodDairy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbx_Kategori = new ComboBox();
            cmx_Yemekler = new ComboBox();
            cbx_Porsiyon = new ComboBox();
            nud_Adet = new NumericUpDown();
            btn_Ekle = new Button();
            dtg_Secilenler = new DataGridView();
            btn_Kaydet = new Button();
            btn_Sil = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbx_Ogun = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nud_Adet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Secilenler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(47, 94);
            label1.Name = "label1";
            label1.Size = new Size(336, 18);
            label1.TabIndex = 0;
            label1.Text = "Yemek Ekleme Sayfasına Hoşgeldiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(54, 218);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 1;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(54, 261);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 1;
            label3.Text = "Yemekler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(54, 305);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 1;
            label4.Text = "Porsiyon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(54, 355);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 1;
            label5.Text = "Adet";
            // 
            // cbx_Kategori
            // 
            cbx_Kategori.Font = new Font("Verdana", 12F);
            cbx_Kategori.FormattingEnabled = true;
            cbx_Kategori.Location = new Point(187, 215);
            cbx_Kategori.Name = "cbx_Kategori";
            cbx_Kategori.Size = new Size(151, 26);
            cbx_Kategori.TabIndex = 2;
            // 
            // cmx_Yemekler
            // 
            cmx_Yemekler.Font = new Font("Verdana", 12F);
            cmx_Yemekler.FormattingEnabled = true;
            cmx_Yemekler.Location = new Point(187, 258);
            cmx_Yemekler.Name = "cmx_Yemekler";
            cmx_Yemekler.Size = new Size(151, 26);
            cmx_Yemekler.TabIndex = 2;
            // 
            // cbx_Porsiyon
            // 
            cbx_Porsiyon.Font = new Font("Verdana", 12F);
            cbx_Porsiyon.FormattingEnabled = true;
            cbx_Porsiyon.Location = new Point(187, 302);
            cbx_Porsiyon.Name = "cbx_Porsiyon";
            cbx_Porsiyon.Size = new Size(151, 26);
            cbx_Porsiyon.TabIndex = 2;
            // 
            // nud_Adet
            // 
            nud_Adet.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nud_Adet.Location = new Point(187, 353);
            nud_Adet.Name = "nud_Adet";
            nud_Adet.Size = new Size(150, 27);
            nud_Adet.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackColor = Color.CadetBlue;
            btn_Ekle.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Ekle.Location = new Point(54, 403);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(241, 31);
            btn_Ekle.TabIndex = 4;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = false;
            // 
            // dtg_Secilenler
            // 
            dtg_Secilenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Secilenler.Location = new Point(381, 153);
            dtg_Secilenler.Name = "dtg_Secilenler";
            dtg_Secilenler.Size = new Size(349, 193);
            dtg_Secilenler.TabIndex = 5;
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.BackColor = Color.CadetBlue;
            btn_Kaydet.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Kaydet.Location = new Point(415, 361);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(281, 33);
            btn_Kaydet.TabIndex = 6;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = false;
            // 
            // btn_Sil
            // 
            btn_Sil.BackColor = Color.DarkOrange;
            btn_Sil.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Sil.Location = new Point(415, 400);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(281, 33);
            btn_Sil.TabIndex = 6;
            btn_Sil.Text = "Seçili Öğeyi Sil";
            btn_Sil.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(55, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(381, 127);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 8;
            label6.Text = "Seçilenler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F);
            label7.Location = new Point(197, 21);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 9;
            label7.Text = "Kalori Hesaplatarak";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 12F);
            label8.Location = new Point(343, 49);
            label8.Name = "label8";
            label8.Size = new Size(324, 28);
            label8.TabIndex = 9;
            label8.Text = "Kilonuzu kontrol altında tutabilirsiniz.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F);
            label9.Location = new Point(53, 173);
            label9.Name = "label9";
            label9.Size = new Size(51, 18);
            label9.TabIndex = 1;
            label9.Text = "Öğün";
            // 
            // cbx_Ogun
            // 
            cbx_Ogun.Font = new Font("Verdana", 12F);
            cbx_Ogun.FormattingEnabled = true;
            cbx_Ogun.Location = new Point(186, 170);
            cbx_Ogun.Name = "cbx_Ogun";
            cbx_Ogun.Size = new Size(151, 26);
            cbx_Ogun.TabIndex = 2;
            // 
            // FoodDairy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_Sil);
            Controls.Add(btn_Kaydet);
            Controls.Add(dtg_Secilenler);
            Controls.Add(btn_Ekle);
            Controls.Add(nud_Adet);
            Controls.Add(cbx_Porsiyon);
            Controls.Add(cmx_Yemekler);
            Controls.Add(cbx_Ogun);
            Controls.Add(cbx_Kategori);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodDairy";
            Text = "FoodDairy";
            ((System.ComponentModel.ISupportInitialize)nud_Adet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Secilenler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbx_Kategori;
        private ComboBox cmx_Yemekler;
        private ComboBox cbx_Porsiyon;
        private NumericUpDown nud_Adet;
        private Button btn_Ekle;
        private DataGridView dtg_Secilenler;
        private Button btn_Kaydet;
        private Button btn_Sil;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbx_Ogun;
    }
}