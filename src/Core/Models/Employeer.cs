using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Employeer : BaseModel
    {
        public string Name { get; set; }
        public int PositionId { get; set; }
        public string? Image { get; set; }
        public EmployeerPosition? Position { get; set; }
        public List<EmployeeSocialMedia>? EmployeeSocialMedia { get; set; }

        [NotMapped]
        public IFormFile? Form_Image { get; set; }

        [NotMapped]
        public List<int>? Form_SocialMediaAccountIds { get; set; }
    }
}
