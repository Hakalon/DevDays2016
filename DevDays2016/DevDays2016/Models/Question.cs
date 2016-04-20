using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;

namespace DevDays2016.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        //一個問題會有多個回應
        public List<Response> responses;
        public User user;

    }
}
