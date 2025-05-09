﻿using Microsoft.EntityFrameworkCore;
using Blazor.Shared.Model;

namespace Blazor.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Evaluate> Evaluates { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<ImageDetails> ImageDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SaleDetails { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
