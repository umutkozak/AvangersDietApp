namespace AvangersDietApp.UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Yonetici = new Button();
            btn_Uye = new Button();
            Btn_UyeOl = new Button();
            txt_Admin = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            msk_AdminPass = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            msk_UserPass = new MaskedTextBox();
            label3 = new Label();
            txt_User = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Yonetici
            // 
            btn_Yonetici.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            btn_Yonetici.Location = new Point(82, 248);
            btn_Yonetici.Name = "btn_Yonetici";
            btn_Yonetici.Size = new Size(298, 74);
            btn_Yonetici.TabIndex = 0;
            btn_Yonetici.Text = "Yönetici Olarak Giriş Yap";
            btn_Yonetici.UseVisualStyleBackColor = true;
            btn_Yonetici.Click += btn_Yonetici_Click;
            // 
            // btn_Uye
            // 
            btn_Uye.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_Uye.Location = new Point(93, 247);
            btn_Uye.Name = "btn_Uye";
            btn_Uye.Size = new Size(316, 71);
            btn_Uye.TabIndex = 1;
            btn_Uye.Text = "Üye Girişi";
            btn_Uye.UseVisualStyleBackColor = true;
 
            // 
            // Btn_UyeOl
            // 
            Btn_UyeOl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Btn_UyeOl.Location = new Point(163, 349);
            Btn_UyeOl.Name = "Btn_UyeOl";
            Btn_UyeOl.Size = new Size(521, 71);
            Btn_UyeOl.TabIndex = 2;
            Btn_UyeOl.Text = "Üye Ol";
            Btn_UyeOl.UseVisualStyleBackColor = true;
            // 
            // txt_Admin
            // 
            txt_Admin.Location = new Point(161, 61);
            txt_Admin.Name = "txt_Admin";
            txt_Admin.Size = new Size(219, 27);
            txt_Admin.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(msk_AdminPass);
            groupBox1.Controls.Add(txt_Admin);
            groupBox1.Controls.Add(btn_Yonetici);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 331);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 121);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 64);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı :";
            // 
            // msk_AdminPass
            // 
            msk_AdminPass.Location = new Point(161, 121);
            msk_AdminPass.Name = "msk_AdminPass";
            msk_AdminPass.Size = new Size(219, 27);
            msk_AdminPass.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(msk_UserPass);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_User);
            groupBox2.Controls.Add(btn_Uye);
            groupBox2.Location = new Point(442, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 321);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 115);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 58);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 5;
            label5.Text = "Kullanıcı Adı :";
            // 
            // msk_UserPass
            // 
            msk_UserPass.Location = new Point(179, 111);
            msk_UserPass.Name = "msk_UserPass";
            msk_UserPass.Size = new Size(219, 27);
            msk_UserPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 58);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(179, 51);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(219, 27);
            txt_User.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 432);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Btn_UyeOl);
            Name = "Main";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Yonetici;
        private Button btn_Uye;
        private Button Btn_UyeOl;
        private TextBox txt_Admin;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox msk_AdminPass;
        private GroupBox groupBox2;
        private Label label4;
        private MaskedTextBox msk_UserPass;
        private Label label3;
        private TextBox txt_User;
        private Label label6;
        private Label label5;
    }
}
