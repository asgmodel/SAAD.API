
using System.Reflection;
using System.Reflection.Emit;
using AutoGenerator;
using AutoGenerator.Data;
 
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SADA.API.Models;

namespace LAHJA.API.Data
{

    public class LahjaDataContext : AutoIdentityDataContext<ApplicationUser, IdentityRole, string>, ITAutoDbContext
    {
        public LahjaDataContext(DbContextOptions<LahjaDataContext> options) : base(options)
        {
        }

    

        //public DbSet<User> Users { get; set; }
        
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<CategoryMedia> CategoryMedias { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductFile> ProductFiles { get; set; }
        //public DbSet<ProductReview> ProductReviews { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Event> Events { get; set; }
        //public DbSet<Operation> Operations { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User configurations

            //modelBuilder.Entity<Order>()
            //   .HasOne(o => o.User)
            //   .WithMany(u => u.Orders)
            //   .HasForeignKey(o => o.UserId)
            //   .OnDelete(DeleteBehavior.Restrict);

            //// User - Transaction
            //modelBuilder.Entity<Transaction>()
            //    .HasOne(t => t.User)
            //    .WithMany(u => u.Transactions)
            //    .HasForeignKey(t => t.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// User - Operation
            //modelBuilder.Entity<Operation>()
            //    .HasOne(op => op.User)
            //    .WithMany(u => u.Operations)
            //    .HasForeignKey(op => op.UserId)
            //    .OnDelete(DeleteBehavior.SetNull);

            //// User - Event
            //modelBuilder.Entity<Event>()
            //    .HasOne(e => e.TriggeredByUser)
            //    .WithMany(u => u.CreatedEvents)
            //    .HasForeignKey(e => e.TriggeredByUserId)
            //    .OnDelete(DeleteBehavior.SetNull);

            //// User - ShoppingCartItem
            //modelBuilder.Entity<ShoppingCartItem>()
            //    .HasOne(sci => sci.User)
            //    .WithMany(u => u.ShoppingCart)
            //    .HasForeignKey(sci => sci.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// User - ProductReview
            //modelBuilder.Entity<ProductReview>()
            //    .HasOne(pr => pr.User)
            //    .WithMany(u => u.ProductReviews)
            //    .HasForeignKey(pr => pr.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// ========== ⁄·«ﬁ«  «·›∆… ==========

            //// Category - CategoryMedia
            //modelBuilder.Entity<CategoryMedia>()
            //    .HasOne(cm => cm.Category)
            //    .WithMany(c => c.CategoryMedia)
            //    .HasForeignKey(cm => cm.CategoryId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// Category - Product
            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(c => c.Products)
            //    .HasForeignKey(p => p.CategoryId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// ========== ⁄·«ﬁ«  «·„‰ Ã ==========

            //// Product - ProductFile
            //modelBuilder.Entity<ProductFile>()
            //    .HasOne(pf => pf.Product)
            //    .WithMany(p => p.ProductFiles)
            //    .HasForeignKey(pf => pf.ProductId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// Product - ProductReview
            //modelBuilder.Entity<ProductReview>()
            //    .HasOne(pr => pr.Product)
            //    .WithMany(p => p.ProductReviews)
            //    .HasForeignKey(pr => pr.ProductId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// Product - ShoppingCartItem
            //modelBuilder.Entity<ShoppingCartItem>()
            //    .HasOne(sci => sci.Product)
            //    .WithMany()
            //    .HasForeignKey(sci => sci.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// ========== ⁄·«ﬁ«  «·ÿ·» ==========

            //// Order - OrderItem
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(oi => oi.Order)
            //    .WithMany(o => o.OrderItems)
            //    .HasForeignKey(oi => oi.OrderId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// OrderItem - Product
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(oi => oi.Product)
            //    .WithMany()
            //    .HasForeignKey(oi => oi.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// ========== ⁄·«ﬁ«  «·√Õœ«À Ê«·⁄„·Ì«  ==========

            //// Event - Operation
            //modelBuilder.Entity<Operation>()
            //    .HasOne(op => op.Event)
            //    .WithMany(e => e.Operations)
            //    .HasForeignKey(op => op.EventId)
            //    .OnDelete(DeleteBehavior.SetNull);

            //// Operation - Transaction
            //modelBuilder.Entity<Transaction>()
            //    .HasOne(t => t.Operation)
            //    .WithMany(op => op.Transactions)
            //    .HasForeignKey(t => t.OperationId)
            //    .OnDelete(DeleteBehavior.SetNull);

            //// Order - Transaction
            //modelBuilder.Entity<Transaction>()
            //    .HasOne(t => t.Order)
            //    .WithMany(o => o.Transactions)
            //    .HasForeignKey(t => t.OrderId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// ========== ≈⁄œ«œ«  ≈÷«›Ì… ==========

            //// ›Â—”… «·ÕﬁÊ· «·„Â„…
            //modelBuilder.Entity<User>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();

            //modelBuilder.Entity<User>()
            //    .HasIndex(u => u.Username)
            //    .IsUnique();

            //modelBuilder.Entity<Product>()
            //    .HasIndex(p => p.SKU)
            //    .IsUnique();

            //modelBuilder.Entity<Order>()
            //    .HasIndex(o => o.OrderDate);

            //modelBuilder.Entity<Transaction>()
            //    .HasIndex(t => t.ReferenceNumber);

            ////  ÕÊÌ· Dictionary ≈·Ï JSON
            //modelBuilder.Entity<Event>()
            //    .Property(e => e.EventData)
            //    .HasColumnType("nvarchar(max)");
            // Conversation configurations

        }
    }
}
