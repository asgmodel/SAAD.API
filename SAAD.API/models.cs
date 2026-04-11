using AutoGenerator;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SADA.API.Models
{
   
    /* ================= ENUMS ================= */
 
   
    public class ApplicationUser : IdentityUser, ITModel
    {
        // يمكن إضافة خصائص إضافية هنا
        public string? FullName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }

    /* ================= USER ================= */
 
    public class User: ITModel
    {
        public string UserId { get; set; }

     
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }

      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        // الصورة الشخصية
        public string ProfilePictureUrl { get; set; }

 

        // الصلاحيات والأدوار
        public string Role { get; set; }  // Admin, Manager, Customer, Staff

        // حالة الحساب
        public bool IsActive { get; set; }
     

        // التواريخ
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

      
        public ICollection<Order> Orders { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Operation> Operations { get; set; }
        public ICollection<Event> CreatedEvents { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCart { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
    }

   
    public class Category: ITModel
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // روابط الملفات (صورة أو فيديو)
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public ICollection<CategoryMedia> CategoryMedia { get; set; }
        public ICollection<Product> Products { get; set; }
    }

 
    public class CategoryMedia: ITModel
    {
        public string  CategoryMediaId { get; set; }
        public int CategoryId { get; set; }
        public string MediaUrl { get; set; }
        public string MediaType { get; set; } // Image, Video
        public string Title { get; set; }
        public int DisplayOrder { get; set; }

        public Category Category { get; set; }
    }

  
    public class Product: ITModel
    {
        public string  ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string SKU { get; set; }
        public string Brand { get; set; }

      
        public int CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

    
        public Category Category { get; set; }
        public ICollection<ProductFile> ProductFiles { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
    }

    
    public class ProductFile: ITModel
    {
        public string  ProductFileId { get; set; }
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; } // Image, Video, PDF
        public long FileSize { get; set; }
        public bool IsMainImage { get; set; }
        public DateTime UploadedAt { get; set; }

        // Navigation property
        public Product Product { get; set; }
    }

 
    public class ShoppingCartItem: ITModel
    {
        public string ShoppingCartItemId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Product Product { get; set; }
    }

    // ============================================
    // 7. تقييمات المنتجات (ProductReview)
    // ============================================
    public class ProductReview: ITModel
    {
        public string  ProductReviewId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }  // 1-5
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsApproved { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Product Product { get; set; }
    }

    // ============================================
    // 8. جدول الطلبات (Order)
    // ============================================
    public class Order: ITModel
    {
        public string OrderId { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        // معلومات الشحن
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingZipCode { get; set; }
        public string ShippingPhone { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }

        public string OrderStatus { get; set; }  // Pending, Confirmed, Shipped, Delivered, Cancelled
        public string PaymentStatus { get; set; } // Paid, Unpaid, Refunded
        public string TrackingNumber { get; set; }

        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

    // ============================================
    // 9. تفاصيل الطلب (OrderItem)
    // ============================================
    public class OrderItem: ITModel
    {
        public string OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice => (UnitPrice * Quantity) - Discount;

        // Navigation properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }

    // ============================================
    // 10. جدول الأحداث (Event)
    // ============================================
    public class Event: ITModel
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }  // OrderCreated, PaymentReceived, StockUpdated, UserRegistered
        public DateTime EventDateTime { get; set; }
        public string Source { get; set; }  // API, UserAction, SystemTrigger
        public string Description { get; set; }

        // من قام بإنشاء/التسبب في هذا الحدث
        public int? TriggeredByUserId { get; set; }
        public string TriggeredBySystem { get; set; }

        public string Severity { get; set; }  // Info, Warning, Error
        //public Dictionary<string, object> EventData { get; set; } // بيانات إضافية

        // Navigation properties
        public User TriggeredByUser { get; set; }
        public ICollection<Operation> Operations { get; set; }
    }

    // ============================================
    // 11. جدول العمليات (Operation)
    // ============================================
    public class Operation: ITModel
    {
        public string OperationId { get; set; }
        public string OperationName { get; set; }  // CreateOrder, ProcessPayment, UpdateInventory, SendEmail
        public DateTime ExecutionTime { get; set; }
        public DateTime? CompletionTime { get; set; }
        public string Status { get; set; }  // Pending, InProgress, Completed, Failed
        public string LogDetails { get; set; }

        // Foreign Keys
        public int? EventId { get; set; }
        public int? UserId { get; set; }

        public int? RetryCount { get; set; }
        public string ErrorMessage { get; set; }

        // Navigation properties
        public Event Event { get; set; }
        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

    // ============================================
    // 12. جدول التعاملات (Transaction)
    // ============================================
    public class Transaction: ITModel
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }  // Payment, Refund, Authorization
        public string PaymentMethod { get; set; }   // CreditCard, PayPal, BankTransfer, Cash
        public string TransactionStatus { get; set; } // Pending, Success, Failed
        public string ReferenceNumber { get; set; }
        public string Notes { get; set; }

        // Foreign Keys
        public int OrderId { get; set; }
        public int? OperationId { get; set; }
        public int UserId { get; set; }

        public string BankReference { get; set; }
        public string CardLastFour { get; set; }
        public DateTime? SettledAt { get; set; }

        // Navigation properties
        public Order Order { get; set; }
        public Operation Operation { get; set; }
        public User User { get; set; }
    }

    ///* ================= CHAT ================= */











}
