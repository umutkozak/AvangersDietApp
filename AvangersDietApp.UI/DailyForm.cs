using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
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
    public partial class DailyForm : Form
    {
        AvangersContext db = new AvangersContext();
        User currentUser = SessionManger.CurrentUser;
        //FoodManager foodManager = new FoodManager();
        
        public DailyForm()
        {
            LoadData();
            InitializeComponent();
            ListOfMeals();
        }


        private void LoadData()
        {
            currentUser = (User)db.Users
                .Include(u => u.UserMealFoods)
                .ThenInclude(uf => uf.Meal)
                .Include(u => u.UserMealFoods)
                .ThenInclude(uf => uf.Food)
                .FirstOrDefault(u => u.Id == currentUser.Id)!;
        }

        private void ListOfMeals()
        {
            foreach (ListBox listBox in Controls.OfType<ListBox>())
            {
                listBox.Items.Clear();
            }

            var userMeals = currentUser.UserMealFoods.Where(u => u.Meal?.MealTime == dtpMealTime.Value.Date).ToList();


            foreach (var item in userMeals!.Where(x =>x.Meal.Name == "Kahvaltı")) 
            {
                lstBreakfast.Items.Add(string.Join(" - ", item.Food!.Name,item.Food.Calories));
            }

            foreach (var item in userMeals!.Where(x => x.Meal.Name == "Ara Öğün"))
            {
                lstBreakfast.Items.Add(string.Join(" - ", item.Food!.Name, item.Food.Calories));
            }

            foreach (var item in userMeals!.Where(x => x.Meal.Name == "Öğle Yemeği"))
            {
                lstBreakfast.Items.Add(string.Join(" - ", item.Food!.Name, item.Food.Calories));
            }

            foreach (var item in userMeals!.Where(x => x.Meal.Name == "Akşam Yemeği"))
            {
                lstBreakfast.Items.Add(string.Join(" - ", item.Food!.Name, item.Food.Calories));
            }

            ShowMealCalorie(userMeals);

            // öğün listelemeyi çöz load datada listleri çıkarıp foodları yüklemen lazım 
        }

        private void ShowMealCalorie(List<UserMealFood> userMeals)
        {
            if (userMeals.Count == 0)
            {
                lblBreakfastCal.Text = lblLunchCal.Text = lblDinnerCal.Text = lblSnackCal.Text = lblTotalCal.Text = userMeals.Count.ToString();
                return;
            }

            lblBreakfastCal.Text = userMeals.FirstOrDefault(um => um.Meal?.Name == "Kahvaltı")?.Food?.Calories.ToString();
            lblLunchCal.Text = userMeals.FirstOrDefault(um => um.Meal?.Name == "Öğle Yemeği")?.Food?.Calories.ToString();
            lblDinnerCal.Text = userMeals.FirstOrDefault(um => um.Meal?.Name == "Akşam Yemeği")?.Food?.Calories.ToString();
            lblSnackCal.Text = userMeals.FirstOrDefault(um => um.Meal?.Name == "Ara Öğün")?.Food?.Calories.ToString();
            lblTotalCal.Text = userMeals.Sum(uf => uf.Food!.Calories /** uf.Portion.Amount*/).ToString();
        }
        private void dtpMealTime_ValueChanged(object sender, EventArgs e)
        {
            ListOfMeals();
        }
    }
}
