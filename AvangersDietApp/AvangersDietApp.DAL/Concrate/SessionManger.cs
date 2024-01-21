using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Concrate
{
    public class SessionManger
    {

        private static User _currentUser = null!;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        private static Meal _currentMeal = null!;

        public static Meal CurrentMeal
        {
            get { return _currentMeal; }
            set { _currentMeal = value; }
        }
    }
}
