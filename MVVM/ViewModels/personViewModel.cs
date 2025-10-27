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
        public Person person { get; set; }
        public personViewModel()
        {
            person = new Person()
            {
                Name = "Alexia",
                Age = 19,
                Married = true,
                Birthday = new DateTime(2006, 08, 19),
                Weight = 70,
                LunchTime = new TimeSpan(12, 30, 0)
            };
        }




    }
}
