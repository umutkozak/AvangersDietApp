using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using AvangersDietApp.DAL.Contract;
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
        AvangersContext db = new AvangersContext();
        User currentUser = SessionManger.CurrentUser;
        Meal currentMeal = SessionManger.CurrentMeal;

        List<UserMealFood> selectedUfs = new List<UserMealFood>();

        Food? food;
        double piece;

        public UserFood()
        {
            LoadData();
            InitializeComponent();
            ShowMealName();
            ListFoodCategories();
            UpdateFoods();
        }

        private void LoadData()
        {
            if (db.Entry(currentMeal).State == EntityState.Detached)
            {
                db.Attach(currentMeal);
            }

            selectedUfs.AddRange(db.UserMealFoods.Include(uf => uf.User).Include(uf => uf.Meal).Include(uf => uf.Food)
                .Where(uf => uf.UserId == currentUser.Id && uf.MealId == currentMeal.FoodId && uf.Meal!.MealTime == currentMeal.MealTime));
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
            dgv_Choosed.DataSource = selectedUfs.Where(uf => uf.Food != null).Select(uf => new
            {
                uf.Food!.Name,
                FoodCalorie = uf.Food!.Calories
            }).ToList();
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
            if (dgv_Choosed.SelectedRows.Count < 0)
                return;

            UserMealFood deletedUfpm = (UserMealFood)dgv_Choosed.SelectedRows[0].DataBoundItem;
           
                selectedUfs.Remove(deletedUfpm);
                UpdateFoods();
        }


        private void UserFoodDairy_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UserMain().ShowDialog();
        }
    }


}
