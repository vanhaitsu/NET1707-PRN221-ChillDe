﻿using IMS.Repositories;
using IMS.Repositories.Entities;
using IMS.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Models.Repositories
{
    public class InternRepository : GenericRepository<Intern>, IInternRepository
    {
        private readonly AppDbContext _dbContext;
        public InternRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Intern> GetInternByMail(string email)
        {
            return await _dbContext.Interns.SingleOrDefaultAsync(a => a.Email.Equals(email));
        }
        public IQueryable<Intern> GetAll()
        {
            return _dbContext.Interns.AsQueryable();
        }

        public async Task<List<Intern>> GetRegisterCustomer()
        {
            return await _dbContext.Interns.Where(c => c.Status == 0).ToListAsync();
        }

        //public async Task<List<InternGetModel>> GetAllTrainees(int pageSize, int pageNumber, string searchTerm)
        //{
        //    IQueryable<Intern> query = _dbContext.Interns.Include(a => a.Scores).Include(a => a.TrainingProgram);
        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        query = query.Where(a =>
        //            a.FullName.Contains(searchTerm.ToLower()) ||
        //            a.Email.Contains(searchTerm.ToLower()) ||
        //            a.PhoneNumber.Contains(searchTerm.ToLower())
        //        );
        //    }

        //    var internModels = await query
        //        .Select(a => new InternGetModel
        //        {
        //            Id = a.Id,
        //            FullName = a.FullName,
        //            Address = a.Address,
        //            DOB = a.DOB,
        //            Email = a.Email,
        //            Gender = a.Gender,
        //            PhoneNumber = a.PhoneNumber,
        //            IsDelete = a.IsDeleted
        //        })
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    return internModels;
        //}

        //public async Task<List<InternGetModel>> GetTraineesByMentor(int pageSize, int pageNumber, string searchTerm, Guid accountId)
        //{
        //    IQueryable<Intern> query = _dbContext.Interns.Include(a => a.Scores).Include(a => a.TrainingProgram);

        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        query = query.Where(a =>
        //            a.FullName.Contains(searchTerm.ToLower()) ||
        //            a.Email.Contains(searchTerm.ToLower()) ||
        //            a.PhoneNumber.Contains(searchTerm.ToLower())
        //        );
        //    }

        //    var internModels = await query
        //        .Where(a => a.TrainingProgram != null && a.TrainingProgram.AccountId == accountId)
        //        .Select(a => new TraineeGetModel
        //        {
        //            Id = a.Id,
        //            FullName = a.FullName,
        //            Address = a.Address,
        //            DOB = a.DOB,
        //            Email = a.Email,
        //            Gender = a.Gender,
        //            PhoneNumber = a.PhoneNumber,
        //            Code = a.Code,
        //            University = a.University,
        //            Status = a.Status,
        //            ProgramId = a.ProgramId,
        //            ProgramName = a.TrainingProgram.Name,
        //            IsDelete = a.IsDeleted
        //        })
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    return traineeModels;
        //}

        //public async Task<List<InternGetModel>> GetTraineesByProgram(int pageSize, int pageNumber,
        //    Guid trainingProgramId)
        //{
        //    IQueryable<Trainee> query = _dbContext.Trainees.Include(a => a.TrainingProgram);
        //    if (trainingProgramId != null)
        //    {
        //        query = query.Where(a =>
        //            a.ProgramId == trainingProgramId
        //        );
        //    }

        //    var traineeModels = await query
        //        .Select(a => new TraineeGetModel
        //        {
        //            Id = a.Id,
        //            FullName = a.FullName,
        //            Address = a.Address,
        //            DOB = a.DOB,
        //            Email = a.Email,
        //            Gender = a.Gender,
        //            PhoneNumber = a.PhoneNumber,
        //            Code = a.Code,
        //            University = a.University,
        //            Status = a.Status,
        //            ProgramId = a.ProgramId,
        //            ProgramName = a.TrainingProgram.Name,
        //            IsDelete = a.IsDeleted
        //        })
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToListAsync();

        //    return traineeModels;
        //}
    }
}