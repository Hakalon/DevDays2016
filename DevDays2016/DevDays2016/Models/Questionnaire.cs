using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDays2016.Models
{
    public class Questionnaire
    {
        [Key]
        public int Id { get; set; }

        public int Place { get; set; }

        public int Staff { get; set; }

        public int Activity { get; set; }

        public string Information { get; set; }

        public string Other { get; set; }

    }
}
