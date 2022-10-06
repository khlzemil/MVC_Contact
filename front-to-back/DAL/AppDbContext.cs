﻿using front_to_back.Models;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<RecentWorkComponent> RecentWorkComponents { get; set; }
        public DbSet<ContractIntroComponent> ContractIntroComponent { get; set; }
        public DbSet<ContactFormComponent> ContactFormComponent { get; set; }
        public DbSet<ContactNumberComponent> ContactNumberComponent { get; set; }
    }
}
