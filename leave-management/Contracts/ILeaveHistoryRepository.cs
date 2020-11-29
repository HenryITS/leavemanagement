using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
        Task<ICollection<LeaveHistory>> GetEmployeesByLeaveType(int id);
    }
}
