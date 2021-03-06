﻿using Microsoft.EntityFrameworkCore;

//SQL Server Cofiguration to connect with Database and 'Subscribers' table is mapped.
namespace SampleDAL
{
    public class SampleDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=Localdb; Trusted_Connection=true;");
        }
        public DbSet<Subscribers> Subscribers { get; set; }
    }
}
