using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface ISocialMediaAccountService
    {
        public Task<List<SocialMedia>> GetAllSocialMedias();
    }
}
