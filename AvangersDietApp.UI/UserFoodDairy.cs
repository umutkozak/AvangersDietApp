using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
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

namespace AvangersDietApp.UI
{
    public partial class UserFoodDairy : Form
    {
        AvangersContext db = new AvangersContext();
        FoodManager FoodList = new FoodManager();
        CategoryManager CategoryList = new CategoryManager();

        FoodStrategy foods = new FoodStrategy();
        Food? food;

        public UserFoodDairy()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void UserFoodDairy_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(MealType)))
            {
                cmb_Meal.Items.Add(item);
            }

            List<Category> allCategories = CategoryList.GetAll();
            foreach (var category in allCategories)
            {
                cmb_Category.Items.Add(category.Name);
            }

            List<Food> allFoods = FoodList.GetAll();
            foreach (var foods in allCategories)
            {
                cmb_Foods.Items.Add(foods.Name);
            }


        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn MealTypeColumn = new DataGridViewComboBoxColumn();
            MealTypeColumn.HeaderText = "Öğün";
            MealTypeColumn.DataSource = Enum.GetValues(typeof(MealType));
            dgv_Choosed.Columns.Add(MealTypeColumn);

            DataGridViewComboBoxColumn CategoryColumn = new DataGridViewComboBoxColumn();
            CategoryColumn.HeaderText = "Kategori";
            CategoryColumn.DataSource = CategoryList;
            dgv_Choosed.Columns.Add(CategoryColumn);

            DataGridViewComboBoxColumn FoodColumn = new DataGridViewComboBoxColumn();
            FoodColumn.HeaderText = "Yemek";
            FoodColumn.DataSource = FoodList;
            dgv_Choosed.Columns.Add(FoodColumn);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
