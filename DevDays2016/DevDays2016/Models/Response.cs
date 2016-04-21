using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DevDays2016.Models
{
    public class Response
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

    }
}
