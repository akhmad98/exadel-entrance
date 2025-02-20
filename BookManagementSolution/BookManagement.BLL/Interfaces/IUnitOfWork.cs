using BookManagementDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposal
    {
        IBRepository Books { get; }
        IRepository<Users> Users { get; }
        int Complete();
    }
}