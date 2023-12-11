using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class SocialMedia : BaseModel
    {
        public string PlatformName { get; set; }
        public List<EmployeeSocialMedia>? EmployeeSocialMedia { get; set; }
    }
}
