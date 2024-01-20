using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using AvangersDietApp.DAL.Contract;
using AvangersDietApp.DAL.DTO;
using AvangersDietApp.DAL.Helper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class UserFood : Form
    {
        SqlConnection baglan = new SqlConnection("server=.;database=AvangersDietDB;uid=sa;pwd=123;trustservercertificate=true;");
        AvangersContext db = new AvangersContext();
        User currentUser = SessionManger.CurrentUser;
        Meal currentMeal = SessionManger.CurrentMeal;

        List<UserMealFood> selectedUfs = new List<UserMealFood>();

        Food? food;
        double piece;

        public UserFood()
        {
           
            InitializeComponent();
            ShowMealName();
            ListFoodCategories();
            UpdateFoods();
        }


        private void ShowMealName()
        {
            lblMealName.Text = currentMeal.MealType.ToString();
        }

        private void ListFoodCategories()
        {
            cmb_Category.Items.Clear();

            foreach (Category categories in db.Category)
            {
                cmb_Category.Items.Add(categories);
            }
        }
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Category.SelectedIndex == -1) return;

            ListFoods();
        }
        private void ListFoods()
        {
            cmb_Foods.DataSource = null;
            cmb_Foods.DataSource = db.Food
                .Where(x => x.Category.Id == ((Category)cmb_Category.SelectedItem).Id)
                .ToList();
        }





        private void UpdateFoods()
        {
            dgv_Choosed.DataSource = null;
            dgv_Choosed.DataSource = selectedUfs.Where(uf => uf.Food != null).Select(uf => new FoofListDto()
            {
                Calories = uf.Food.Calories,
                Name = uf.Food.Name,
                Id = uf.Food.Id,
            }

            ).ToList();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            food = (Food)cmb_Foods.SelectedItem;
            piece = (double)nud_Count.Value;
            if (food == null)
            {
                MessageBox.Show("Lütfen Bir Yemek Seçiniz.");
                return;
            }

            if (selectedUfs.Any(x => x.FoodId == food!.Id))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedUfs.Add(new UserMealFood()
            {
                User = db.Users.FirstOrDefault(u => u.Id == currentUser.Id),
                UserId = db.Users.FirstOrDefault(u => u.Id == currentUser.Id)!.Id,
                Meal = currentMeal,
                MealId = currentMeal.MealId,
                Food = food,
                FoodId = food!.Id,
              
            });

            UpdateFoods();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            currentMeal.UserMealFoods.RemoveAll(uf => uf.UserId == currentUser.Id);
            currentMeal.UserMealFoods.AddRange(selectedUfs);
            currentMeal.Calorie = 0;
            currentMeal.Calorie += currentMeal.UserMealFoods.Sum(uf => uf.Food!.Calories);

            db.SaveChanges();
            MessageBox.Show($"Yemekler {currentMeal.MealName} öğününüze başarıyla eklenmiştir.");
            Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //if (dgv_Choosed.SelectedRows.Count < 0)
            //    return;

            //UserMealFood deletedUfpm = (UserMealFood)dgv_Choosed.SelectedRows[0].DataBoundItem;

            //    selectedUfs.Remove(deletedUfpm);
            //    UpdateFoods();---null exeption entity

            try
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("DELETE FROM UserMealFood WHERE Name = @Name", baglan);
                kmt.Parameters.AddWithValue("@Name", dgv_Choosed.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Silindi");


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu");
            }
        }


        private void UserFoodDairy_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UserMain().ShowDialog();
        }


    }


}
