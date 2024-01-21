using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvangersDietApp.DAL.Contract
{
    public enum Gender
    {
        [Description("Erkek")]
        Erkek = 0,
        [Description("Kadın")]
        Kadın = 1,
    }
}
