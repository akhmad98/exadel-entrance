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
        BooksDTO GetById(int id);
        private BooksDTO GetByTitle(int id);
        // Books GetAllBookTitlesFromMostToLess();
        BooksDTO Update(ICreateBooks book);
        BooksDTO Create(ICreateBooks book);
        // void Remove(int id);
    }
}