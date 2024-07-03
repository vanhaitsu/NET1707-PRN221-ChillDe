﻿using IMS.Models.Entities;
using Model.ViewModels.AccountModel;

namespace IMS_View.Services.Interfaces
{
    public interface IAccountService
    {
        Task<AccountLoginModel> CheckLogin(string email, string password);
        Task<bool> CheckExistedAccount(string email);
        Task<Account> GetAccountAsync(Guid id);
        Task<bool> SignUp(AccountRegisterModel accountRegisterModel);
        Task<bool> Update(Guid id,AccountUpdateModel accountUpdateModel);
        Task<bool> Delete(Guid id);
        Task<List<AccountGetModel>> GetAllAccounts(int PageSize,int  PageNumber,string SearchTerm);
        Task<bool> Create(AccountRegisterModel accountRegisterModel);
        Task<List<AccountGetModel>> SearchAccountsAsync(string searchTerm);
        Task<int> GetTotalAccountsCount(string searchTerm);
        Task<bool> Restore(Guid id);
    }
}
