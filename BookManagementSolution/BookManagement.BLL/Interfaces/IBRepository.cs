using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.DAL.Data;
using BookManagement.DAL.Data.DTOs;

namespace BookManagement.BLL.Interfaces
{
    public interface IBRepository : IRepository<Books>
    {
        // Books GetById(int id);
        // void Update(Books books);
    }
}