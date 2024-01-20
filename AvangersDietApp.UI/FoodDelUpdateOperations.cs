using AvangersDietApp.BLL.Concrate;
using Microsoft.Data.SqlClient;
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
    public partial class FoodDelUpdateOperations : Form
    {
        public FoodDelUpdateOperations()
        {
            InitializeComponent();
        }
        FoodManager foodManager = new FoodManager();
        SqlConnection baglan = new SqlConnection("server=.;database=AvangersDietDB;uid=sa;pwd=123;trustservercertificate=true;");
        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("UPDATE Food SET Name = @Name," +
                    "CategoryId=@CategoryId," +
                    "Description=@Description," +
                    " Carbohydrate=@Carbohydrate," +
                    "Proteins=@Proteins," +
                    "Fats=@Fats," +
                    "Calories=@Calories" +
                    "WHERE Id = @Id", baglan);
                kmt.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["Id"].Value);
                kmt.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells["Name"].Value);
                kmt.Parameters.AddWithValue("@CategoryId", dataGridView1.CurrentRow.Cells["CategoryId"].Value);
                kmt.Parameters.AddWithValue("@Description", dataGridView1.CurrentRow.Cells["Description"].Value);
                kmt.Parameters.AddWithValue("@Carbohydrate", dataGridView1.CurrentRow.Cells["Carbohydrate"].Value);
                kmt.Parameters.AddWithValue("@Proteins", dataGridView1.CurrentRow.Cells["Proteins"].Value);
                kmt.Parameters.AddWithValue("@Fats", dataGridView1.CurrentRow.Cells["Fats"].Value);
                kmt.Parameters.AddWithValue("@Calories", dataGridView1.CurrentRow.Cells["Calories"].Value);
                kmt.ExecuteNonQuery();
                baglan.Close();
                dataGridView1.DataSource = foodManager.GetAll();
                MessageBox.Show("İşlem Başarılı");

            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik Bir Hata Oluştu.");
            }

        }

        private void FoodDelUpdateOperations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = foodManager.GetAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("DELETE FROM Food WHERE Name = @Name", baglan);
                kmt.Parameters.AddWithValue("@Name", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                baglan.Close();
                dataGridView1.DataSource = foodManager.GetAll();
                MessageBox.Show("Kayıt Silindi");


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu");
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FoodDelUpdateOperations_Load_2(object sender, EventArgs e)
        {
            dataGridView1.DataSource = foodManager.GetAll();
        }
    }
}
