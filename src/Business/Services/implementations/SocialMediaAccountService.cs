using Business.Services.Interfaces;
using Core.Models;
using Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.implementations
{
    public class SocialMediaAccountService : ISocialMediaAccountService
    {
        private ISocialMediaRepository _socialMediaRepo;
        public SocialMediaAccountService(ISocialMediaRepository socialMediaRepo)
        {
            _socialMediaRepo = socialMediaRepo;
        }


        public async Task<List<SocialMedia>> GetAllSocialMedias()
        {
            return await _socialMediaRepo.GetAllAsync();
        }
    }
}
