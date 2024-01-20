namespace AvangersDietApp.UI
{
    partial class FoodDelUpdateOperations
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
            dataGridView1 = new DataGridView();
            btn_Update = new Button();
            btn_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(773, 333);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Update.Location = new Point(27, 367);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(315, 52);
            btn_Update.TabIndex = 1;
            btn_Update.Text = "Yemek Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Delete.Location = new Point(395, 367);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(325, 52);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Yemek Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // FoodDelUpdateOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            BackgroundImage = Properties.Resources.black_1072366_12804;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 363);
            Controls.Add(button2);
            Controls.Add(button1);

            ClientSize = new Size(800, 451);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);

            Controls.Add(dataGridView1);
            Name = "FoodDelUpdateOperations";
            Text = "FoodDelUpdateOperations";
            Load += FoodDelUpdateOperations_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Update;
        private Button btn_Delete;
    }
}