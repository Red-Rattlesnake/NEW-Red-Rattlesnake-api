﻿using RedRattlesnake.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace RedRattlesnake.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}
