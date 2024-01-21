namespace AvangersDietApp.UI
{
    partial class Reports
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
            lst_FoodRank = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 20);
            label1.TabIndex = 0;
            label1.Text = "En Fazla Tüketilen Yiyecekler Listesi(Çoktan Aza Sıralı)";
            // 
            // lst_FoodRank
            // 
            lst_FoodRank.FormattingEnabled = true;
            lst_FoodRank.Location = new Point(0, 35);
            lst_FoodRank.Name = "lst_FoodRank";
            lst_FoodRank.Size = new Size(387, 384);
            lst_FoodRank.TabIndex = 1;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_FoodRank);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lst_FoodRank;
    }
}