using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class EmployeeSocialMedia
    {
        
        public int EmployeerId { get; set; }
        public int SocialMediaId { get; set; }

        public string Url { get; set; }

        public Employeer Employeer { get; set; }
        public SocialMedia SocialMedia { get; set;}
    }
}
