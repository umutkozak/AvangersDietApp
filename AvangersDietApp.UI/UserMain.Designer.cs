namespace AvangersDietApp.UI
{
    partial class UserMain
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
            pictureBox1 = new PictureBox();
            lblTotalCal = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblUserName = new Label();
            panel1 = new Panel();
            btnBreakfast = new Button();
            lblBreakfastCal = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLunch = new Button();
            lblLunchCal = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            btnDinner = new Button();
            lblDinnerCal = new Label();
            label8 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            btnSnack = new Button();
            lblSnackCal = new Label();
            label11 = new Label();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            picbTrends = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbTrends).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.meal;
            pictureBox1.Location = new Point(181, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTotalCal
            // 
            lblTotalCal.AutoSize = true;
            lblTotalCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalCal.Location = new Point(473, 271);
            lblTotalCal.Name = "lblTotalCal";
            lblTotalCal.Size = new Size(19, 18);
            lblTotalCal.TabIndex = 1;
            lblTotalCal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(429, 306);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 2;
            label1.Text = "Alınan Kalori";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(428, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(429, 98);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(116, 18);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btnBreakfast);
            panel1.Controls.Add(lblBreakfastCal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 79);
            panel1.TabIndex = 5;
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackColor = Color.Transparent;
            btnBreakfast.BackgroundImage = Properties.Resources.button2;
            btnBreakfast.BackgroundImageLayout = ImageLayout.Stretch;
            btnBreakfast.Location = new Point(107, 13);
            btnBreakfast.Name = "btnBreakfast";
            btnBreakfast.Size = new Size(64, 53);
            btnBreakfast.TabIndex = 6;
            btnBreakfast.UseVisualStyleBackColor = false;
            btnBreakfast.Click += btnBreakfast_Click;
            // 
            // lblBreakfastCal
            // 
            lblBreakfastCal.AutoSize = true;
            lblBreakfastCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBreakfastCal.Location = new Point(3, 53);
            lblBreakfastCal.Name = "lblBreakfastCal";
            lblBreakfastCal.Size = new Size(19, 18);
            lblBreakfastCal.TabIndex = 4;
            lblBreakfastCal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(56, 53);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 3;
            label3.Text = "cal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 2;
            label2.Text = "Kahvaltı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(btnLunch);
            panel2.Controls.Add(lblLunchCal);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(298, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 79);
            panel2.TabIndex = 7;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.Transparent;
            btnLunch.BackgroundImage = Properties.Resources.button2;
            btnLunch.BackgroundImageLayout = ImageLayout.Stretch;
            btnLunch.Location = new Point(108, 13);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(64, 53);
            btnLunch.TabIndex = 6;
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // lblLunchCal
            // 
            lblLunchCal.AutoSize = true;
            lblLunchCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLunchCal.Location = new Point(3, 53);
            lblLunchCal.Name = "lblLunchCal";
            lblLunchCal.Size = new Size(19, 18);
            lblLunchCal.TabIndex = 4;
            lblLunchCal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(56, 53);
            label5.Name = "label5";
            label5.Size = new Size(32, 18);
            label5.TabIndex = 3;
            label5.Text = "cal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(99, 16);
            label6.TabIndex = 2;
            label6.Text = "Öğle Yemeği";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(btnDinner);
            panel3.Controls.Add(lblDinnerCal);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(505, 521);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 79);
            panel3.TabIndex = 7;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.Transparent;
            btnDinner.BackgroundImage = Properties.Resources.button2;
            btnDinner.BackgroundImageLayout = ImageLayout.Stretch;
            btnDinner.Location = new Point(117, 13);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(64, 53);
            btnDinner.TabIndex = 6;
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += btnDinner_Click;
            // 
            // lblDinnerCal
            // 
            lblDinnerCal.AutoSize = true;
            lblDinnerCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDinnerCal.Location = new Point(3, 53);
            lblDinnerCal.Name = "lblDinnerCal";
            lblDinnerCal.Size = new Size(19, 18);
            lblDinnerCal.TabIndex = 4;
            lblDinnerCal.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(56, 53);
            label8.Name = "label8";
            label8.Size = new Size(32, 18);
            label8.TabIndex = 3;
            label8.Text = "cal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(3, 13);
            label9.Name = "label9";
            label9.Size = new Size(115, 16);
            label9.TabIndex = 2;
            label9.Text = "Akşam Yemeği";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(btnSnack);
            panel4.Controls.Add(lblSnackCal);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(709, 521);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 79);
            panel4.TabIndex = 7;
            // 
            // btnSnack
            // 
            btnSnack.BackColor = Color.Transparent;
            btnSnack.BackgroundImage = Properties.Resources.button2;
            btnSnack.BackgroundImageLayout = ImageLayout.Stretch;
            btnSnack.Location = new Point(107, 13);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(64, 53);
            btnSnack.TabIndex = 6;
            btnSnack.UseVisualStyleBackColor = false;
            btnSnack.Click += btnSnack_Click;
            // 
            // lblSnackCal
            // 
            lblSnackCal.AutoSize = true;
            lblSnackCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSnackCal.Location = new Point(3, 53);
            lblSnackCal.Name = "lblSnackCal";
            lblSnackCal.Size = new Size(19, 18);
            lblSnackCal.TabIndex = 4;
            lblSnackCal.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(56, 53);
            label11.Name = "label11";
            label11.Size = new Size(32, 18);
            label11.TabIndex = 3;
            label11.Text = "cal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(3, 13);
            label12.Name = "label12";
            label12.Size = new Size(74, 16);
            label12.TabIndex = 2;
            label12.Text = "Ara Öğün";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(816, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(159, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // picbTrends
            // 
            picbTrends.Image = Properties.Resources.barchart1;
            picbTrends.Location = new Point(12, 12);
            picbTrends.Name = "picbTrends";
            picbTrends.Size = new Size(117, 71);
            picbTrends.SizeMode = PictureBoxSizeMode.Zoom;
            picbTrends.TabIndex = 9;
            picbTrends.TabStop = false;
            picbTrends.Click += picbTrends_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 10;
            label4.Text = "Trendler";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 659);
            Controls.Add(label4);
            Controls.Add(picbTrends);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(lblTotalCal);
            Controls.Add(pictureBox1);
            Name = "UserMain";
            Text = "UserMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbTrends).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTotalCal;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lblUserName;
        private Panel panel1;
        private Label lblBreakfastCal;
        private Label label3;
        private Label label2;
        private Button btnBreakfast;
        private Panel panel2;
        private Button btnLunch;
        private Label lblLunchCal;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Button btnDinner;
        private Label lblDinnerCal;
        private Label label8;
        private Label label9;
        private Panel panel4;
        private Button btnSnack;
        private Label lblSnackCal;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private PictureBox picbTrends;
        private Label label4;
    }
}