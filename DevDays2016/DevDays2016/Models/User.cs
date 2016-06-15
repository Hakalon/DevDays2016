using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DevDays2016.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string NickName { get; set; }

        public string Profession { get; set; }

        public string InterestIn { get; set; }

        public string WantToMeet { get; set; }
    }
}
