﻿using IMS.Repositories.Entities;
using IMS.Repositories.Models.CommonModel;
using IMS.Repositories.Models.InternModel;

namespace IMS.Services.Interfaces
{
    public interface IInternService
    {
        Task<LoginResult> CheckLogin(string email, string password);
        Task<bool> CheckExistedIntern(string email);
        Task<bool> SignUp(InternRegisterModel internRegisterModel);
        Task<List<string>> GetAllInternEmails();
        Task<bool> Create(InternRegisterModel internRegisterModel);
        Task<bool> CreateRange(List<InternRegisterModel> internRegisterModels);
        Task<Intern> GetInternAsync(Guid id);
        Task<List<InternGetModel>> GetAllInterns(InternFilterModel filterModel);
        Task<int> GetTotalInternsCount(InternFilterModel filterModel);
        Task<bool> Update(Guid id, InternUpdateModel internUpdateModel);
        Task<bool> Delete(Guid id);
        Task<bool> Restore(Guid id);
        Task<Intern> GetByEmail(string email);
        Task<List<Intern>> GetRegisterCustomer();
        Task<bool> RegisterIntern(Intern intern);
        Task<bool> Edit(Intern intern);
        Task<bool> HardDelete(Guid id);
    }
}
