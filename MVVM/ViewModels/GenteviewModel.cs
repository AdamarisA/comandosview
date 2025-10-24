using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_AA.MVVM.ViewModels
{
    internal class GenteviewModel
    {
        public List<string> Gente { get; set; }

        public GenteviewModel()
        {
            Gente = new List<string>
            {
                "Alexia",
                "Adamaris",
                "Paola",
                "Maria",
                "Isabel",
                "Sofia",
                "Tania",
                "Lourdes"
            };
        }
    }
}
