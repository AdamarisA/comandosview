using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_AA.MVVM.Models
{
  public class person
  {   
            public string Name { get; set; }
            public int Age { get; set; }
            public bool married { get; set; }
            public DateTime birthday { get; set; }
            public int weight { get; set; }
            public TimeSpan LunchTime { get; set; }

  }
    
}
