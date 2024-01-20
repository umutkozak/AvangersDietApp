using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
using AvangersDietApp.DAL.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = AvangersDietApp.DAL.Concrate.User;

namespace AvangersDietApp.UI
{
    public partial class UserMain : Form
    {
        AvangersContext db = new AvangersContext();
        private readonly User _currentUser;
        User? dbUser;
        Meal? currentMeal;
        List<UserMealFood>? userMeals;
        public UserMain()
        {
            _currentUser = SessionManger.CurrentUser;
            LoadData();
            InitializeComponent();
            ShowUserName();
            ShowMealCalorie();
        }

        private void CheckMeal(Meal meal)
        {
            SessionManger.CurrentMeal = meal;
            db.Entry(meal).State = EntityState.Detached;
            db.SaveChanges();

            Close();
            new UserFoodDairy().ShowDialog();
        }
        private void LoadData()
        {
            dbUser = db.Users
                .Include(u => u.UserMealFoods)
                .ThenInclude(uf => uf.Meal)
                .FirstOrDefault(u => u.Id == _currentUser.Id);
        }
        private void ShowUserName()
        {
            lblUserName.Text = _currentUser.UserName;
        }

        private void ShowMealCalorie()
        {
            var a = dateTimePicker1.Value.Date;
            userMeals = dbUser!.UserMealFoods.Where(uf => uf.Meal?.MealTime == dateTimePicker1.Value.Date).ToList();

            if (userMeals.Count == 0)
            {
                lblBreakfastCal.Text = lblLunchCal.Text = lblDinnerCal.Text = lblSnackCal.Text = lblTotalCal.Text = userMeals.Count.ToString();
                return;
            }

            lblBreakfastCal.Text = userMeals.FirstOrDefault(um => um.Meal?.MealType == MealType.BreakFast)?.Meal?.Calorie.ToString();
            lblLunchCal.Text = userMeals.FirstOrDefault(um => um.Meal?.MealType == MealType.Lunch)?.Meal?.Calorie.ToString();
            lblDinnerCal.Text = userMeals.FirstOrDefault(um => um.Meal?.MealType == MealType.Dinner)?.Meal?.Calorie.ToString();
            lblSnackCal.Text = userMeals.FirstOrDefault(um => um.Meal?.MealType == MealType.Snack)?.Meal?.Calorie.ToString();
            lblTotalCal.Text = userMeals.Sum(uf => uf.Meal!.Calorie).ToString();
        }


        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealType == MealType.BreakFast)?.Meal;

            if (currentMeal != null)
            {
                CheckMeal(currentMeal);
            }
            currentMeal = new Meal() { MealType = MealType.BreakFast, MealTime = dateTimePicker1.Value.Date };
            SessionManger.CurrentMeal = currentMeal;
            db.Entry(currentMeal).State = EntityState.Detached;
            db.SaveChanges();
            Close();
            new UserFoodDairy().ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealType == MealType.Lunch)?.Meal;

            if (currentMeal != null)
            {
                CheckMeal(currentMeal);
            }
            currentMeal = new Meal() { MealType = MealType.Lunch, MealTime = dateTimePicker1.Value.Date };
            SessionManger.CurrentMeal = currentMeal;
            db.Entry(currentMeal).State = EntityState.Detached;
            db.SaveChanges();
            Close();
            new UserFoodDairy().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealType == MealType.Dinner)?.Meal;

            if (currentMeal != null)
            {
                CheckMeal(currentMeal);
            }

            currentMeal = new Meal() { MealType = MealType.Dinner, MealTime = dateTimePicker1.Value.Date };
            SessionManger.CurrentMeal = currentMeal;
            db.Entry(currentMeal).State = EntityState.Detached;
            db.SaveChanges();
            Close();
            new UserFoodDairy().ShowDialog();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealType == MealType.Snack)?.Meal;

            if (currentMeal != null)
            {
                CheckMeal(currentMeal);
            }

            currentMeal = new Meal() { MealType = MealType.Snack, MealTime = dateTimePicker1.Value.Date };
            SessionManger.CurrentMeal = currentMeal;
            db.Entry(currentMeal).State = EntityState.Detached;
            db.SaveChanges();
            Close();
            new UserFoodDairy().ShowDialog();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowMealCalorie();
        }

        private void picbTrends_Click(object sender, EventArgs e)
        {
            new Trends().ShowDialog();
        }
    }
}
