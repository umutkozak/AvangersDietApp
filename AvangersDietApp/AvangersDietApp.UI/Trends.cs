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
    public partial class Trends : Form
    {
        AvangersContext db = new AvangersContext();
        User currentUser = SessionManger.CurrentUser;

        public Trends()
        {
            LoadData();
            InitializeComponent();
            ShowUserName();
            Top5Food();
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

        private void ShowUserName()
        {
            lblName.Text = currentUser.UserName;
        }

        private void Top5Food()
        {
            var foodList = db.UserMealFoods.Include(uf => uf.Food).GroupBy(x => x.FoodId).OrderByDescending(x => x.Count()).Take(5).Select(uf => new
            {
                YemekAdi = uf.FirstOrDefault()!.Food!.Name,
                YenmeSayisi = uf.Count()
            });

            foreach (var food in foodList)
            {
                lstTop5.Items.Add(food);
            }
        }


        private string FindFoodName(int foodId)
        {
            if (foodId == 0)
                return "Bu hafta öğünlerin boş :)";
            return db.Food.Where(x => x.Id == foodId).FirstOrDefault()!.Name;
        }
        private int FindFoodId(List<UserMealFood> ufList)
        {
            int maxCount = 0;
            int count = 0;
            int maxFoodId = 0;

            var foodList = ufList.Select(uf => uf.FoodId).ToList();

            foreach (int foodId in foodList.Distinct())
            {
                count = foodList.Count(f => f == foodId);

                if (count > maxCount)
                {
                    maxCount = count;
                    maxFoodId = foodId;
                }
            }

            return maxFoodId;
        }


        private List<UserMealFood> FindUserMealFood(MealType mealType, int option, int reportType)
        {
            int dayNo = reportType == 0 ? -(int)DateTime.Now.DayOfWeek : -DateTime.Now.Day;

            if (option == 0)
            {
                return currentUser.UserMealFoods.Where(x => x.Meal!.MealType == mealType).Where(x => x.Meal!.MealTime > DateTime.Now.AddDays(dayNo) && x.Meal.MealTime <= DateTime.Now).ToList();
            }
            else
            {
                var ufs = new List<UserMealFood>();

                foreach (User user in db.Users.Include(u => u.UserMealFoods).ThenInclude(uf => uf.Meal))
                {
                    ufs.AddRange(user.UserMealFoods.Where(x => x.Meal!.MealType == mealType).Where(x => x.Meal!.MealTime > DateTime.Now.AddDays(dayNo) && x.Meal.MealTime.Day <= DateTime.Now.Day).ToList());
                }

                return ufs;
            }
        }
        private void AllUserFoods(int reportType)
        {
            lblAllUserBreakfast.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.BreakFast, 1, reportType)));
            lblAllUserLunch.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Lunch, 1, reportType)));
            lblAllUserDinner.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Dinner, 1, reportType)));
            lblAllUserSnack.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Snack, 1, reportType)));
        }

        private void UserFoods(int reportType)
        {
            lblCurrentUserBreakfast.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.BreakFast, 0, reportType)));
            lblCurrentUserLunch.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Lunch, 0, reportType)));
            lblCurrentUserDinner.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Dinner, 0, reportType)));
            lblCurrentUserSnack.Text = FindFoodName(FindFoodId(FindUserMealFood(MealType.Snack, 0, reportType)));
        }

        private void btnMothly_Click(object sender, EventArgs e)
        {
            UserFoods(1);
            AllUserFoods(1);
        }

        private void btnWeekly_Click_1(object sender, EventArgs e)
        {
            UserFoods(0);
            AllUserFoods(0);
        }
    }
}
