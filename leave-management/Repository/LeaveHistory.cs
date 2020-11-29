using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(global::LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(global::LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<global::LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public global::LeaveHistory FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<global::LeaveHistory>> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(global::LeaveHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
