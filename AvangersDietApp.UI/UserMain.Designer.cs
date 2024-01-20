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
            picbTrends = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            btnBreakfast = new Button();
            label3 = new Label();
            lblBreakfastCal = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            btnLunch = new Button();
            label2 = new Label();
            lblLunchCal = new Label();
            label5 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            label4 = new Label();
            lblDinnerCal = new Label();
            label7 = new Label();
            panel4 = new Panel();
            btnSnack = new Button();
            label8 = new Label();
            lblSnackCal = new Label();
            label10 = new Label();
            lblTotalCal = new Label();
            label9 = new Label();
            lblUserName = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)picbTrends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // picbTrends
            // 
            picbTrends.Image = Properties.Resources.barchart1;
            picbTrends.Location = new Point(12, 12);
            picbTrends.Name = "picbTrends";
            picbTrends.Size = new Size(105, 72);
            picbTrends.SizeMode = PictureBoxSizeMode.Zoom;
            picbTrends.TabIndex = 0;
            picbTrends.TabStop = false;
            picbTrends.Click += picbTrends_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.meal;
            pictureBox2.Location = new Point(114, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(644, 321);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Bisque;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(388, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(btnBreakfast);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblBreakfastCal);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 486);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 88);
            panel1.TabIndex = 3;
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackColor = Color.Transparent;
            btnBreakfast.BackgroundImage = Properties.Resources.button1;
            btnBreakfast.BackgroundImageLayout = ImageLayout.Stretch;
            btnBreakfast.Location = new Point(115, 14);
            btnBreakfast.Name = "btnBreakfast";
            btnBreakfast.Size = new Size(66, 57);
            btnBreakfast.TabIndex = 3;
            btnBreakfast.UseVisualStyleBackColor = false;
            btnBreakfast.Click += btnBreakfast_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 57);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 2;
            label3.Text = "Cal";
            // 
            // lblBreakfastCal
            // 
            lblBreakfastCal.AutoSize = true;
            lblBreakfastCal.BackColor = Color.Transparent;
            lblBreakfastCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBreakfastCal.Location = new Point(7, 57);
            lblBreakfastCal.Name = "lblBreakfastCal";
            lblBreakfastCal.Size = new Size(19, 18);
            lblBreakfastCal.TabIndex = 1;
            lblBreakfastCal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(61, 14);
            label1.TabIndex = 0;
            label1.Text = "Kahvaltı";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(728, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(btnLunch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblLunchCal);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(237, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 88);
            panel2.TabIndex = 4;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.Transparent;
            btnLunch.BackgroundImage = Properties.Resources.button2;
            btnLunch.BackgroundImageLayout = ImageLayout.Stretch;
            btnLunch.Location = new Point(114, 14);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(66, 57);
            btnLunch.TabIndex = 3;
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(60, 57);
            label2.Name = "label2";
            label2.Size = new Size(35, 18);
            label2.TabIndex = 2;
            label2.Text = "Cal";
            // 
            // lblLunchCal
            // 
            lblLunchCal.AutoSize = true;
            lblLunchCal.BackColor = Color.Transparent;
            lblLunchCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLunchCal.Location = new Point(7, 57);
            lblLunchCal.Name = "lblLunchCal";
            lblLunchCal.Size = new Size(19, 18);
            lblLunchCal.TabIndex = 1;
            lblLunchCal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(7, 14);
            label5.Name = "label5";
            label5.Size = new Size(92, 14);
            label5.TabIndex = 0;
            label5.Text = "Öğle Yemeği";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblDinnerCal);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(440, 486);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 88);
            panel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.button3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(111, 14);
            button1.Name = "button1";
            button1.Size = new Size(66, 57);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(60, 57);
            label4.Name = "label4";
            label4.Size = new Size(35, 18);
            label4.TabIndex = 2;
            label4.Text = "Cal";
            // 
            // lblDinnerCal
            // 
            lblDinnerCal.AutoSize = true;
            lblDinnerCal.BackColor = Color.Transparent;
            lblDinnerCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDinnerCal.Location = new Point(7, 57);
            lblDinnerCal.Name = "lblDinnerCal";
            lblDinnerCal.Size = new Size(19, 18);
            lblDinnerCal.TabIndex = 1;
            lblDinnerCal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 14);
            label7.Name = "label7";
            label7.Size = new Size(105, 14);
            label7.TabIndex = 0;
            label7.Text = "Akşam Yemeği";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Controls.Add(btnSnack);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lblSnackCal);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(642, 486);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 88);
            panel4.TabIndex = 6;
            // 
            // btnSnack
            // 
            btnSnack.BackColor = Color.Transparent;
            btnSnack.BackgroundImage = Properties.Resources.button4;
            btnSnack.BackgroundImageLayout = ImageLayout.Stretch;
            btnSnack.Location = new Point(114, 14);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(66, 57);
            btnSnack.TabIndex = 3;
            btnSnack.UseVisualStyleBackColor = false;
            btnSnack.Click += btnSnack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(60, 57);
            label8.Name = "label8";
            label8.Size = new Size(35, 18);
            label8.TabIndex = 2;
            label8.Text = "Cal";
            // 
            // lblSnackCal
            // 
            lblSnackCal.AutoSize = true;
            lblSnackCal.BackColor = Color.Transparent;
            lblSnackCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSnackCal.Location = new Point(7, 57);
            lblSnackCal.Name = "lblSnackCal";
            lblSnackCal.Size = new Size(19, 18);
            lblSnackCal.TabIndex = 1;
            lblSnackCal.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(7, 14);
            label10.Name = "label10";
            label10.Size = new Size(92, 14);
            label10.TabIndex = 0;
            label10.Text = "Öğle Yemeği";
            // 
            // lblTotalCal
            // 
            lblTotalCal.AutoSize = true;
            lblTotalCal.BackColor = Color.Transparent;
            lblTotalCal.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalCal.ForeColor = Color.Chartreuse;
            lblTotalCal.Location = new Point(428, 265);
            lblTotalCal.Name = "lblTotalCal";
            lblTotalCal.Size = new Size(19, 18);
            lblTotalCal.TabIndex = 4;
            lblTotalCal.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(383, 301);
            label9.Name = "label9";
            label9.Size = new Size(116, 18);
            label9.TabIndex = 4;
            label9.Text = "Alınan Kalori";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(418, 85);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(49, 18);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(19, 87);
            label11.Name = "label11";
            label11.Size = new Size(84, 18);
            label11.TabIndex = 7;
            label11.Text = "Trendler";
            // 
            // UserMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ana_yemekler;
            ClientSize = new Size(938, 599);
            Controls.Add(label11);
            Controls.Add(lblUserName);
            Controls.Add(label9);
            Controls.Add(lblTotalCal);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(picbTrends);
            Name = "UserMain";
            Text = "UserMain";
            ((System.ComponentModel.ISupportInitialize)picbTrends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbTrends;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button btnBreakfast;
        private Label label3;
        private Label lblBreakfastCal;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Button btnLunch;
        private Label label2;
        private Label lblLunchCal;
        private Label label5;
        private Panel panel3;
        private Button button1;
        private Label label4;
        private Label lblDinnerCal;
        private Label label7;
        private Panel panel4;
        private Button btnSnack;
        private Label label8;
        private Label lblSnackCal;
        private Label label10;
        private Label lblTotalCal;
        private Label label9;
        private Label lblUserName;
        private Label label11;
    }
}