﻿using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class FailteDbContext : DbContext
    {
        public FailteDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedTime = DateTime.UtcNow;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
