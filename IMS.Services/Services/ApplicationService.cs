﻿using IMS.Repositories.Entities;
using IMS.Repositories.Enums;
using IMS.Repositories.Interfaces;
using IMS.Repositories.Models.NewFolder;
using IMS.Services.Interfaces;

namespace IMS.Services.Services
{
    public class ApplicationService : IApplicationService
    {

        private readonly IUnitOfWork _unitofWork;
       

        public ApplicationService(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
           

        }
        public async Task<List<Application>> GetApplicationsByCampaignID(Guid campaignId)
        {
            return await _unitofWork.ApplicationRepository.GetApplications(campaignId);
        }

        public async Task<Application> GetByInternIdAndCampaignId(Guid internId, Guid campaignId)
        {
            return await _unitofWork.ApplicationRepository.GetByInternIdAndCampaignId(internId,campaignId);
        }

        public async Task<bool> UpdateStatus(Guid applicationId, string status, Guid createdBy)
        {
            var ApplicationToUpdate = await _unitofWork.ApplicationRepository.GetAsync(applicationId);
            if (ApplicationToUpdate != null)
            {
                if (status.Equals("Accepted"))
                {
                    ApplicationToUpdate.Status = ApplicationStatus.Accpeted;

                }
                if (status == ApplicationStatus.Rejected.ToString())
                {
                    ApplicationToUpdate.Status = ApplicationStatus.Rejected;
                }




                ApplicationToUpdate.CreatedBy = createdBy;
                _unitofWork.ApplicationRepository.Update(ApplicationToUpdate);
                await _unitofWork.SaveChangeAsync();
                return true;
            }
            return false;
        }
    }
}
