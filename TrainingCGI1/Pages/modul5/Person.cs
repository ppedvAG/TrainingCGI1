using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCGI1.Pages.modul5
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Da amuss was rein")]
        public int Gross { get; set; }
        [Required(ErrorMessage ="Da amuss was rein")]
        [Range(minimum:140,maximum:195,ErrorMessage ="keine Achterbahn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da amuss was rein")]
        [StringLength(maximumLength:20,ErrorMessage ="zu lange")]
        public DateTime GebDat { get; set; }
    }
}
