﻿using ApiApplikation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiApplikation.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<CategoryEntity> Categories { get; set; } = null!;
        public virtual DbSet<ProductEntity> Products { get; set; } = null!;
    }
}
