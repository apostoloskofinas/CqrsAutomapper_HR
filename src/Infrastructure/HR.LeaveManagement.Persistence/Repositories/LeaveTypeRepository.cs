﻿using HR.LeaveManagement.Application.Contracts.Persistance;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, 
        ILeaveTypeRepository
    {
        public LeaveTypeRepository(HrDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsLeaveTypeUnique(string name)
        {
            return await _context.LeaveTypes.AnyAsync(t => t.Name == name); //I have specific contract
        }
    }
}
