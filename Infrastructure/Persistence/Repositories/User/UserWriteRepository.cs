using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(FailteDbContext context) : base(context)
        {
        }
    }
}
