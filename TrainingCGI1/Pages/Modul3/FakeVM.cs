using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCGI1.Pages.Modul3
{
    public class FakeVM
    {

        public string User { get; set; }
        public List<string> Tage { get; set; }
       public void Init()
        {
            Tage = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                Tage.Add(DateTime.Now.AddDays(i).ToString("dddd"));
            }



        }
    }
}
