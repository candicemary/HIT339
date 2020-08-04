using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebAPP._00data
{
    public class Movie

    {
        public int MovieID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public string Director { get; set; }
        public string Release_Dates { get; set; }
        public string Email { get; set; }
        public string language { get; set; }
        public string category { get; set; }
    }
   



}

