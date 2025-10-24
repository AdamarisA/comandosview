using MVVM_AA.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_AA.MVVM.ViewModels
{
    internal class personViewModel
    {
        public person person { get; set; }
        public personViewModel()
        {
            person = new person()
            {
                Name = "Alexia",
                Age = 19,
                married = true,
                birthday = new DateTime(2006, 08, 19),
                weight = 70,
                LunchTime = new TimeSpan(12, 30, 0)
            };
        }




    }
}
