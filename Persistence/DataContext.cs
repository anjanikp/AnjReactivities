﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Value> Values { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Value>()
      .HasData(

        new Value { Id = 1, Name = "Value101" },
        new Value { Id = 2, Name = "Value102" },
        new Value { Id = 3, Name = "Value103" },
        new Value { Id = 4, Name = "Value104" },
        new Value { Id = 5, Name = "Value105" },
        new Value { Id = 6, Name = "Value106" },
        new Value { Id = 7, Name = "Value107" }

      );
    }
  }
}
