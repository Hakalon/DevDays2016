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

        //一個使用者會有多個回應
        public List<Response> responses;
        public List<Question> questions;

    }
}
