using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly FailteDbContext _context;

        public WriteRepository(FailteDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public Task<bool> AddAsync(T entity)
        {
           T
        }

        public Task<bool> AddRangeAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
