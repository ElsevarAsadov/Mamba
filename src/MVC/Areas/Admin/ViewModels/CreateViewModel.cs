using Core.Models;

namespace MVC.Areas.Admin.ViewModels
{
    public class CreateViewModel
    {
        public Employeer Employeer {get; set;}
        public List<SocialMedia> SocialMediaAccounts { get; set;}
        public List<EmployeerPosition> EmplooyeePositions { get; set; }
    }
}
