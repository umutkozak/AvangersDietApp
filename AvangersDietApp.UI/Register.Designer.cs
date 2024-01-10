namespace AvangersDietApp.UI
{
    partial class Register
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
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            txt_Username = new TextBox();
            msk_Pwd = new MaskedTextBox();
            msk_PwdAgain = new MaskedTextBox();
            numeric_Weight = new NumericUpDown();
            btn_KayitOl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmb_Gender = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numeric_Weight).BeginInit();
            SuspendLayout();
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(206, 25);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(250, 27);
            txt_FirstName.TabIndex = 0;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(206, 58);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(250, 27);
            txt_LastName.TabIndex = 0;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(206, 91);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(250, 27);
            txt_Username.TabIndex = 0;
            // 
            // msk_Pwd
            // 
            msk_Pwd.Location = new Point(206, 124);
            msk_Pwd.Name = "msk_Pwd";
            msk_Pwd.Size = new Size(250, 27);
            msk_Pwd.TabIndex = 1;
            // 
            // msk_PwdAgain
            // 
            msk_PwdAgain.Location = new Point(206, 157);
            msk_PwdAgain.Name = "msk_PwdAgain";
            msk_PwdAgain.Size = new Size(250, 27);
            msk_PwdAgain.TabIndex = 1;
            // 
            // numeric_Weight
            // 
            numeric_Weight.Location = new Point(207, 247);
            numeric_Weight.Name = "numeric_Weight";
            numeric_Weight.Size = new Size(150, 27);
            numeric_Weight.TabIndex = 2;
            // 
            // btn_KayitOl
            // 
            btn_KayitOl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_KayitOl.Location = new Point(206, 290);
            btn_KayitOl.Name = "btn_KayitOl";
            btn_KayitOl.Size = new Size(250, 46);
            btn_KayitOl.TabIndex = 3;
            btn_KayitOl.Text = "Kayıt Ol";
            btn_KayitOl.UseVisualStyleBackColor = true;
            btn_KayitOl.Click += btn_KayitOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 94);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 127);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 160);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Şifre Tekrar :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 249);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 4;
            label6.Text = "Kilo :";
            // 
            // cmb_Gender
            // 
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Location = new Point(206, 207);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new Size(151, 28);
            cmb_Gender.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 210);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 4;
            label7.Text = "Cinsiyet :";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 365);
            Controls.Add(cmb_Gender);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_KayitOl);
            Controls.Add(numeric_Weight);
            Controls.Add(msk_PwdAgain);
            Controls.Add(msk_Pwd);
            Controls.Add(txt_Username);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_Weight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private TextBox txt_Username;
        private MaskedTextBox msk_Pwd;
        private MaskedTextBox msk_PwdAgain;
        private NumericUpDown numeric_Weight;
        private Button btn_KayitOl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmb_Gender;
        private Label label7;
    }
}