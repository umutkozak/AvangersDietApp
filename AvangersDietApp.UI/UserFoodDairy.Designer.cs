namespace AvangersDietApp.UI
{
    partial class UserFoodDairy
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
            cmb_Category = new ComboBox();
            cmb_Foods = new ComboBox();
            cmb_Portion = new ComboBox();
            label6 = new Label();
            cmb_Daily = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dgv_Choosed = new DataGridView();
            label7 = new Label();
            btn_Add = new Button();
            btn_Save = new Button();
            btn_Clear = new Button();
            nud_Count = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_Choosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Count).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(53, 138);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Öğün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(53, 189);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 0;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(53, 237);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 0;
            label3.Text = "Yemekler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(53, 295);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 0;
            label4.Text = "Porsiyon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(53, 356);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 0;
            label5.Text = "Adet";
            // 
            // cmb_Category
            // 
            cmb_Category.Font = new Font("Verdana", 12F);
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(185, 186);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(213, 26);
            cmb_Category.TabIndex = 1;
            cmb_Category.SelectedIndexChanged += cmb_Category_SelectedIndexChanged;
            // 
            // cmb_Foods
            // 
            cmb_Foods.Font = new Font("Verdana", 12F);
            cmb_Foods.FormattingEnabled = true;
            cmb_Foods.Location = new Point(185, 237);
            cmb_Foods.Name = "cmb_Foods";
            cmb_Foods.Size = new Size(213, 26);
            cmb_Foods.TabIndex = 1;
            cmb_Foods.SelectedIndexChanged += cmb_Foods_SelectedIndexChanged;
            // 
            // cmb_Portion
            // 
            cmb_Portion.Font = new Font("Verdana", 12F);
            cmb_Portion.FormattingEnabled = true;
            cmb_Portion.Location = new Point(185, 292);
            cmb_Portion.Name = "cmb_Portion";
            cmb_Portion.Size = new Size(213, 26);
            cmb_Portion.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(53, 97);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 0;
            label6.Text = "Tarih";
            // 
            // cmb_Daily
            // 
            cmb_Daily.Font = new Font("Verdana", 12F);
            cmb_Daily.FormattingEnabled = true;
            cmb_Daily.Location = new Point(185, 135);
            cmb_Daily.Name = "cmb_Daily";
            cmb_Daily.Size = new Size(213, 26);
            cmb_Daily.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 12F);
            dateTimePicker1.Location = new Point(157, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dgv_Choosed
            // 
            dgv_Choosed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Choosed.Location = new Point(476, 156);
            dgv_Choosed.Name = "dgv_Choosed";
            dgv_Choosed.Size = new Size(251, 200);
            dgv_Choosed.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(476, 135);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 4;
            label7.Text = "Seçilenler";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Add.Location = new Point(197, 390);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(179, 35);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "Ekle";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Ekle_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Save.Location = new Point(476, 390);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(96, 35);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btn_Clear.Location = new Point(652, 390);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 35);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Sil";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // nud_Count
            // 
            nud_Count.Location = new Point(185, 351);
            nud_Count.Name = "nud_Count";
            nud_Count.Size = new Size(213, 23);
            nud_Count.TabIndex = 6;
            // 
            // UserFoodDairy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nud_Count);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Save);
            Controls.Add(btn_Add);
            Controls.Add(label7);
            Controls.Add(dgv_Choosed);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmb_Portion);
            Controls.Add(cmb_Foods);
            Controls.Add(cmb_Daily);
            Controls.Add(cmb_Category);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "UserFoodDairy";
            Text = "UserFoodDairy";
            Load += UserFoodDairy_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Choosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Count).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmb_Category;
        private ComboBox cmb_Foods;
        private ComboBox cmb_Portion;
        private Label label6;
        private ComboBox cmb_Daily;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv_Choosed;
        private Label label7;
        private Button btn_Add;
        private Button btn_Save;
        private Button btn_Clear;
        private NumericUpDown nud_Count;
    }
}