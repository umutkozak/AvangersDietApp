﻿namespace AvangersDietApp.UI
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            cmb_Category = new ComboBox();
            cmb_Foods = new ComboBox();
            dgv_Choosed = new DataGridView();
            label7 = new Label();
            btn_Add = new Button();
            btn_Clear = new Button();
            nud_Count = new NumericUpDown();
            btn_save = new Button();
            lblMealName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Choosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Count).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(52, 226);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 0;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(52, 274);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 0;
            label3.Text = "Yemekler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(53, 334);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 0;
            label5.Text = "Adet";
            // 
            // cmb_Category
            // 
            cmb_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Category.Font = new Font("Verdana", 12F);
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(184, 223);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(213, 26);
            cmb_Category.TabIndex = 1;
            cmb_Category.SelectedIndexChanged += cmb_Category_SelectedIndexChanged;
            // 
            // cmb_Foods
            // 
            cmb_Foods.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Foods.Font = new Font("Verdana", 12F);
            cmb_Foods.FormattingEnabled = true;
            cmb_Foods.Location = new Point(184, 274);
            cmb_Foods.Name = "cmb_Foods";
            cmb_Foods.Size = new Size(213, 26);
            cmb_Foods.TabIndex = 1;
            // 
            // dgv_Choosed
            // 
            dgv_Choosed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Choosed.Location = new Point(476, 30);
            dgv_Choosed.Name = "dgv_Choosed";
            dgv_Choosed.Size = new Size(370, 326);
            dgv_Choosed.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(616, 9);
            label7.Name = "label7";
            label7.Size = new Size(92, 18);
            label7.TabIndex = 4;
            label7.Text = "Seçilenler";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Add.Location = new Point(185, 390);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(106, 36);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "Ekle";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Clear.Location = new Point(740, 390);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(106, 36);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Sil";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // nud_Count
            // 
            nud_Count.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nud_Count.Location = new Point(185, 329);
            nud_Count.Name = "nud_Count";
            nud_Count.Size = new Size(213, 27);
            nud_Count.TabIndex = 6;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_save.Location = new Point(476, 390);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(89, 36);
            btn_save.TabIndex = 8;
            btn_save.Text = "Kaydet";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click_1;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Transparent;
            lblMealName.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMealName.ForeColor = Color.Crimson;
            lblMealName.Location = new Point(60, 51);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(0, 32);
            lblMealName.TabIndex = 9;
            // 
            // UserFoodDairy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.yinimodel_post_dietgreenhouseeffect_1280x720_min31;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(858, 450);
            Controls.Add(lblMealName);
            Controls.Add(btn_save);
            Controls.Add(nud_Count);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Add);
            Controls.Add(label7);
            Controls.Add(dgv_Choosed);
            Controls.Add(cmb_Foods);
            Controls.Add(cmb_Category);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "UserFoodDairy";
            Text = "UserFoodDairy";
            FormClosing += UserFoodDairy_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgv_Choosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Count).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmb_Category;
        private ComboBox cmb_Foods;
        private ComboBox cmb_Portion;
        private DataGridView dgv_Choosed;
        private Label label7;
        private Button btn_Add;
        private Button btn_Clear;
        private NumericUpDown nud_Count;
        private Button btn_save;
        private Label lblMealName;
    }
}