﻿using Microsoft.EntityFrameworkCore;
using ng2trello_backend.Models;

namespace ng2trello_backend.Database.Contexts
{
  public class CommentContext: DbContext
  {
    public CommentContext(DbContextOptions<CommentContext> options) : base(options) { }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Comment>().HasKey(m => m.Id);
      base.OnModelCreating(builder);
    }
  }
}