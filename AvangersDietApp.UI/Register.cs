using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AvangersDietApp.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            if (CheckControls() || ChekPassword())
            {
                MessageBox.Show("Hatasız Doldurunuz");
                return;
            }
            User user = new User();
            user.Name = txt_FirstName.Text;
            user.LastName = txt_LastName.Text;
            user.UserName = txt_Username.Text;
            user.Gender = (Gender)cmb_Gender.SelectedValue;
            user.Password = msk_Pwd.Text;
            user.Weight = Convert.ToInt32(numeric_Weight.Value);
            user.BirthDate = dtpBirthDate.Value;



            var UserList = userManager.GetAll();
            if (!UserList.Any(k => k.UserName == user.UserName))
            {
                userManager.Add(user);
                MessageBox.Show("Kayıt İşlemi Başarılı");
                new Main().Show();
            }
            else
            {
                MessageBox.Show("Aynı İsimde Kullanıcı Var İşlem Başarısız...");
            }


        }

        bool CheckControls()
        {
            foreach (Control item in this.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool ChekPassword()
        {
            if (msk_Pwd.Text == msk_PwdAgain.Text)
            {
                return false;
            }
            return true;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            cmb_Gender.DataSource = Enum.GetValues(typeof(Gender));
        }

    }
}
