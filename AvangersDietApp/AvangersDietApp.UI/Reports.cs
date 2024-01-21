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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        AvangersContext context=new AvangersContext();
        private void Reports_Load(object sender, EventArgs e)
        {
            FoodStrategyManager foodStrategyManager = new FoodStrategyManager();
            var foodList=foodStrategyManager.GetAll();
            
            for (int i = 0; i < foodList.Count; i++) 
            {
               
            }
        }
    }
}
