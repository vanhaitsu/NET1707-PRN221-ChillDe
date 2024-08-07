﻿using IMS.Models.Repositories;
using IMS.Repositories.Entities;
using IMS.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Repositories.Repositories
{
    public class MentorshipRepository : GenericRepository<Mentorship>, IMentorshipRepository
    {
        private readonly AppDbContext _dbContext;
        public MentorshipRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
    
    
}
