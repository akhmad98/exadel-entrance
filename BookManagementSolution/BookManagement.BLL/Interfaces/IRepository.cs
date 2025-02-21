using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManagement.DAL.Data;

namespace BookManagement.BLL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
    }
    
}