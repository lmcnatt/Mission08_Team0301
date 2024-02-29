using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace Mission08_Team0301.Models;

public partial class AddTaskContext : DbContext
{
    public AddTaskContext()
    {
    }

    public AddTaskContext(DbContextOptions<AddTaskContext> options)
    : base(options)
    {
    }

    public virtual DbSet<Task> Tasks{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlite("Data Source=TaskData.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId).HasColumnName("TaskId");
            entity.Property(e => e.TaskName).HasColumnType("NUMERIC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
