using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvangersDietApp.UI
{
    public partial class AdminOperations : Form
    {
        public AdminOperations()
        {
            InitializeComponent();
        }

        private void btnFoodDelUpd_Click(object sender, EventArgs e)
        {
            FoodDelUpdateOperations fdo = new FoodDelUpdateOperations();
            fdo.Show();
            this.Close();
        }

        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
