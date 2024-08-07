﻿using AutoMapper;
using IMS.Repositories.Entities;
using IMS.Repositories.Interfaces;
using IMS.Repositories.Models.AssignmentModels;
using IMS.Repositories.Models.FeedbackModel;
using IMS.Repositories.QueryModels;
using IMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        

        public async Task<QueryResultModel<List<Feedback>>> GetFeedbacks(FeedbackFilterModel feedbackFilterModel)
        {
            var feedbackList = await _unitOfWork.FeedbackRepository.GetAllAsync(
                x => x.IsDeleted == feedbackFilterModel.IsDeleted &&
                (feedbackFilterModel.InternId == null || x.InternId == feedbackFilterModel.InternId) &&
                (feedbackFilterModel.TrainingProgramId == null || x.TrainingProgramId == feedbackFilterModel.TrainingProgramId) &&
                (feedbackFilterModel.AccountId == null || x.AccountId == feedbackFilterModel.AccountId) &&
                (string.IsNullOrEmpty(feedbackFilterModel.Search)
                    || x.Intern.FullName.ToLower().Contains(feedbackFilterModel.Search.ToLower())
                    || x.Intern.Email.ToLower().Contains(feedbackFilterModel.Search.ToLower())
                    || x.TrainingProgram.Name.ToLower().Contains(feedbackFilterModel.Search.ToLower())
                    || x.Account.FullName.ToLower().Contains(feedbackFilterModel.Search.ToLower())
                    || x.Account.Email.ToLower().Contains(feedbackFilterModel.Search.ToLower())
                    || x.Comment.ToLower().Contains(feedbackFilterModel.Search.ToLower())),
                orderBy: x => feedbackFilterModel.OrderByDescending
                    ? x.OrderByDescending(x => x.CreationDate)
                    : x.OrderBy(x => x.CreationDate),
                pageIndex: feedbackFilterModel.PageNumber,
                pageSize: feedbackFilterModel.PageSize,
                includeProperties: "Intern, TrainingProgram, Account"
                );
            return feedbackList;
        }

        public async Task<bool> Create(FeedbackCreateModel feedbackCreateModel)
        {
            var existedIntern = await _unitOfWork.InternRepository.GetAsync(feedbackCreateModel.InternID);
            var existedMentor = await _unitOfWork.AccountRepository.GetAsync(feedbackCreateModel.MentorId);
            var existedTrainingProgram = await _unitOfWork.TrainingProgramRepository.GetAsync(feedbackCreateModel.TraningProgramId);
            if(existedIntern != null && existedMentor != null && existedTrainingProgram != null)
            {
                var newFeedback = new Feedback()
                {
                    CreatedBy = feedbackCreateModel.CreatedBy,
                    InternId = feedbackCreateModel.InternID,
                    AccountId = feedbackCreateModel.MentorId,
                    TrainingProgramId = feedbackCreateModel.TraningProgramId,
                    CreationDate = DateTime.Now,
                    Comment = feedbackCreateModel.commnent
                    
                };

                   await _unitOfWork.FeedbackRepository.AddAsync(newFeedback);
                   await _unitOfWork.SaveChangeAsync();
                    return true;
                
            }
            return false;
        }

        public async Task<bool> DeleteFeedback(Guid fbId)
        {
            var FeedbackToDelete = await _unitOfWork.FeedbackRepository.GetAsync(fbId);
            if(FeedbackToDelete != null) {
                _unitOfWork.FeedbackRepository.HardDelete(FeedbackToDelete);
                _unitOfWork.SaveChangeAsync();
                return true;

            }
            return false;
        }
    }
}
