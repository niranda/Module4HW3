﻿using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopApp.EntityConfigurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).IsRequired().HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(p => p.Rate).IsRequired().HasColumnName("Rate");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasMaxLength(7);
        }
    }
}
