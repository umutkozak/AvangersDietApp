using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class UserFoodDairy : Form
    {
        AvangersContext db = new AvangersContext();
        User currentUser = new User();
        FoodManager foodList = new FoodManager();
        CategoryManager categoryList = new CategoryManager();
        List<FoodStrategy> selectedUfs = new List<FoodStrategy>();
        Food? food;

        public UserFoodDairy()
        {
            InitializeComponent();
        }

        private void ListFood()
        {
            foodList.GetAll();
        }
        private void ListCategory()
        {
            categoryList.GetAll();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (dgv_Choosed.SelectedRows.Count < 0)
                return;
            FoodStrategy deletedUfs = (FoodStrategy)dgv_Choosed.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Seçili yemeği silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                selectedUfs.Remove(deletedUfs);
            }
        }
        private void UpdateFoods()
        {
            dgv_Choosed.DataSource = null;
            dgv_Choosed.DataSource = selectedUfs.Select(uf => new
            {
                // Yemek adı, posiyon, Kalori*Porsiyon bilgisi gelecek
            }).ToList();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            food = (Food)cmb_Foods.SelectedItem;
            //yemekle birlikte gelecek bilgiler neler olacaksa onlar eklenecek..
            if (selectedUfs.Any(x => x.Id == food!.Id))
            {
                MessageBox.Show("Eklemek istediğiniz yemek listede mevcuttur.");
                return;
            }

            selectedUfs.Add(new FoodStrategy()
            {

            });
        }

        private void UserFoodDairy_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Foods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Foods.SelectedIndex == -1)
                return;
            ListFood();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Category.SelectedIndex == -1)
                return;
            ListCategory();
        }
    }
}
