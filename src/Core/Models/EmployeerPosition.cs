using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class EmployeerPosition : BaseModel
    {
        public string Name { get; set; }
        public List<Employeer> Employeers { get; set; }
    }
}
