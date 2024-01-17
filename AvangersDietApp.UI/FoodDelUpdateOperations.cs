using AvangersDietApp.BLL.Concrate;
using AvangersDietApp.DAL.Concrate;
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
        Food food = new Food();
        private void FoodDelUpdateOperations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= foodManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            var food = dataGridView1.Rows[rowIndex].Cells["UpddatedColumn"].Value;
            try
            {
                foodManager.Update((Food)food);
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik Bir Hata Oluştu."); ;
            }
            dataGridView1.DataSource = foodManager.GetAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

            if (food.Id==rowID)
            {
                foodManager.Delete(food);
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.");
            }

            dataGridView1.DataSource = foodManager.GetAll();
        }
    }
}
