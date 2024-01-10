using AvangersDietApp.DAL.Concrate;

namespace AvangersDietApp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Yonetici_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.AdminName=txt_Admin.Text;
            admin.Password=msk_AdminPass.Text;

            if (string.IsNullOrWhiteSpace(txt_Admin.Text)||string.IsNullOrWhiteSpace(msk_AdminPass.Text))
            {
                MessageBox.Show("Lütfen yönetici adý ve þifrenizi giriniz.");
                txt_Admin.Text = "";
                msk_AdminPass.Text = "";
            }
            else if (admin.AdminName!=txt_Admin.Text)
            {
                MessageBox.Show("Yönetici adýnýz hatalý! Lütfen tekrar giriniz.");
                txt_Admin.Text = "";
                msk_AdminPass.Text = "";
            }
            else if (admin.Password!= msk_AdminPass.Text)
            {
                MessageBox.Show("Þifreniz hatalý! Lütfen tekrar giriniz.");
                txt_Admin.Text = "";
                msk_AdminPass.Text = "";
            }
            else
            {
                AdminOperations adminOperations = new AdminOperations();
                adminOperations.Show();
                this.Hide();
            }

        }

        private void btn_Uye_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserName=txt_User.Text;
            user.Password=msk_UserPass.Text;

            if (string.IsNullOrWhiteSpace(txt_User.Text)||string.IsNullOrWhiteSpace(msk_UserPass.Text))
            {
                MessageBox.Show("Lütfen yönetici adý ve þifrenizi giriniz.");
                txt_User.Text= "";
                msk_UserPass.Text = "";
            }
            else if (user.UserName!=txt_User.Text)
            {
                MessageBox.Show("Yönetici adýnýz hatalý! Lütfen tekrar giriniz.");
                txt_User.Text = "";
                msk_UserPass.Text = "";
            }
            else if (user.Password!= msk_UserPass.Text)
            {
                MessageBox.Show("Þifreniz hatalý! Lütfen tekrar giriniz.");
                txt_User.Text = "";
                msk_UserPass.Text = "";
            }
            else
            {

            }
        }

        private void Btn_UyeOl_Click(object sender, EventArgs e)
        {
            
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();

        }
    }
}
