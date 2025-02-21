using BookManagement.DAL.Data;
using BookManagement.BLL.Interfaces;
using BookManagement.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Users = new Repository<Users>(_context);
            Books = new BooksRepository(context);
        }
        public IRepository<Users> Users { get; private set; }
        public IBRepository Books { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}