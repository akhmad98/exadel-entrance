using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BookManagement.DAL.Data;
using BookManagement.DAL.Data.DTOs;

namespace BookManagement.BLL.Interfaces
{
    public interface IBRepository : IRepository<Books>
    {
        Task<ActionResult<Books>> GetById(int id);
        private Task<ActionResult<Books>> GetByTitle(string title);
        // Books GetAllBookTitlesFromMostToLess();
        Task<ActionResult> Update(Books book);
        Task<ActionResult> Create(Books book);
        // void Remove(int id);
    }
}