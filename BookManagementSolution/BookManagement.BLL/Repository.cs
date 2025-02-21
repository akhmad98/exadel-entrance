using System;
using BookManagement.DAL.Data;
using BookManagement.DAL.Data.DTOs;
using BookManagement.BLL.Interfaces;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.BLL
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationContext _context;
        protected readonly DbSet<T> _entities;
        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public IQueryable<T> GetAll() 
        {
            return _entities.AsQueryable();
        }
    }
}