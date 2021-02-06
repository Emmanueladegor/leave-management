using System;
using leave_management.Data;

namespace leave_management.Models.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
    }
}