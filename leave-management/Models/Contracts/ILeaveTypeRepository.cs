using System;
using System.Collections.Generic;
using leave_management.Data;

namespace leave_management.Models.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int id);
    }
}
