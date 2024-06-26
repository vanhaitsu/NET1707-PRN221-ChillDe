﻿using IMS.Models.Entities;
using IMS.Models.Interfaces;

namespace IMS_View.Models.Interfaces
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role> GetByName(string name);
    }
}
