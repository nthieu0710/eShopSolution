using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.OrderDate).HasDefaultValue(DateTime.Now);
            builder.Property(t => t.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.ShipAddress).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.ShipName).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.ShipPhoneNumber).IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
