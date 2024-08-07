﻿using AutoMapper;
using IMS.Repositories.Entities;
using IMS.Repositories.Interfaces;
using IMS.Repositories.Models.AssignmentModels;
using IMS.Repositories.QueryModels;
using IMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssignmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Create(AssignmentCreateModel assignmentCreateModel)
        {
            var assignment = _mapper.Map<Assignment>(assignmentCreateModel);
            assignment.CreationDate = DateTime.UtcNow;
            assignment.EndDate = assignment.StartDate.Value.AddDays(assignmentCreateModel.Duration);
            _unitOfWork.AssignmentRepository.AddAsync(assignment);
            if (await _unitOfWork.SaveChangeAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Update(AssignmentUpdateModel assignmentUpdateModel)
        {
            var assignment = await _unitOfWork.AssignmentRepository.GetAsync(assignmentUpdateModel.Id);
            if (assignment == null)
            {
                return false;
            }
            assignment.ModificationDate = DateTime.UtcNow;
            assignment.Name = assignmentUpdateModel.Name;
            assignment.Description = assignmentUpdateModel.Description;
            assignment.Type = assignmentUpdateModel.Type;
            assignment.StartDate = assignmentUpdateModel.StartDate;
            assignment.Material = assignmentUpdateModel.Material;
            assignment.KPI = assignmentUpdateModel.KPI;
            assignment.Duration = assignmentUpdateModel.Duration;
            assignment.InternId = assignmentUpdateModel.InternId;
            assignment.Comment = assignmentUpdateModel.Comment;
            assignment.PerformanceRating = assignmentUpdateModel.PerformanceRating;
            assignment.CreationDate = DateTime.UtcNow;
            assignment.EndDate = assignment.StartDate.Value.AddDays(assignmentUpdateModel.Duration);
            _unitOfWork.AssignmentRepository.Update(assignment);
            if (await _unitOfWork.SaveChangeAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<QueryResultModel<List<Assignment>>> GetAssignments(AssignmentFilterModel assignmentFilterModel)
        {
            var assignmentList = await _unitOfWork.AssignmentRepository.GetAllAsync(
                filter: x =>
                x.IsDeleted == assignmentFilterModel.IsDeleted &&
                x.TrainingProgramId == assignmentFilterModel.TrainingProgramId &&
                    (string.IsNullOrEmpty(assignmentFilterModel.Search)
                    || x.Name.ToLower().Contains(assignmentFilterModel.Search.ToLower())
                    || x.Material.ToLower().Contains(assignmentFilterModel.Search.ToLower())
                    || x.Comment.ToLower().Contains(assignmentFilterModel.Search.ToLower())
                    || x.Intern.FullName.ToLower().Contains(assignmentFilterModel.Search.ToLower())
                    || x.Description.ToLower().Contains(assignmentFilterModel.Search.ToLower())),
                orderBy: x => assignmentFilterModel.OrderByDescending
                    ? x.OrderByDescending(x => x.CreationDate)
                    : x.OrderBy(x => x.CreationDate),
                pageIndex: assignmentFilterModel.PageNumber,
                pageSize: assignmentFilterModel.PageSize,
                includeProperties: "Intern"
            );

            return assignmentList;
        }

        public async Task<bool> Delete(Guid id)
        {
            var assignment = await _unitOfWork.AssignmentRepository.GetAsync(id);
            if (assignment == null)
            {
                return false;
            }

            _unitOfWork.AssignmentRepository.SoftDelete(assignment);
            return await _unitOfWork.SaveChangeAsync() > 0;
        }

        public async Task<List<AssignmentViewModel>> GetAssignmentsByInternId(Guid internId)
        {
            var assignments = await _unitOfWork.AssignmentRepository.GetAssignmentsByInternId(internId);
            var result = _mapper.Map<List<AssignmentViewModel>>(assignments);
            if (result != null) return result;
            return null;
        }
    }
}
