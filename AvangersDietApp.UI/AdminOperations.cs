using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
using AvangersDietApp.DAL.Context;
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

        CategoryManager categoryManager = new CategoryManager();
        Category category = new Category();

        private void btnFoodDelUpd_Click(object sender, EventArgs e)
        {
            FoodDelUpdateOperations fdo = new FoodDelUpdateOperations();
            fdo.Show();
            this.Close();
        }

        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Category.Text))
            {
                category.Name=txt_Category.Text;
                categoryManager.Add(category);
            }
            else
            {
                MessageBox.Show("Eksiksiz Doldurunuz");
            }



        }

        private void AdminOperations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=categoryManager.GetAll();
        }

        private void btn_CategoryUpd_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            var category = dataGridView1.Rows[rowIndex].Cells["UpddatedColumn"].Value;
            try
            {
                categoryManager.Update((Category)category);
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik Bir Hata Oluştu."); ;
            }
            dataGridView1.DataSource = categoryManager.GetAll();

        }

        private void btn_CategoryDel_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

            if (category.Id==rowID)
            {
                categoryManager.Delete(category);
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.");
            }

            dataGridView1.DataSource = categoryManager.GetAll();

        }

        private void btn_FoodAdd_Click(object sender, EventArgs e)
        {
            FoodManager foodmanager = new FoodManager();
            Food food = new Food();
            try
            {
                if (CheckControls())
                {
                    food.Name=Txt_FoodName.Text;
                    food.Description=rch_FoodDesc.Text;
                    food.CategoryId=cmbCategoryId.SelectedIndex+1;
                    food.Calories=Convert.ToDouble(nmr_Calories.Value);
                    food.Carbohydrates=Convert.ToDouble(nmr_Carbonhid.Value);
                    food.Proteins=Convert.ToDouble(nmr_Protein.Value);
                    food.Fats=Convert.ToDouble(nmr_Fat.Value);
                    foodmanager.Add(food);
                    MessageBox.Show("İşlem Başarılı");

                }
                else
                {
                    MessageBox.Show("Eksiksiz Doldurunuz...");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu.Tekrar Deneyin");
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
                if (item is System.Windows.Forms.NumericUpDown)
                {
                    if (((NumericUpDown)item).Value>=0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

     
    }
}
