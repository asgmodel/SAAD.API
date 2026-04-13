using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// User  property for VM Create.
    /// </summary>
    public class UserCreateVM : ITVM
    {
        ///
        //public String? UserId { get; set; }
        ///
        public String? Username { get; set; }
        ///
        public String? Email { get; set; }
        ///
        public String? PasswordHash { get; set; }
        ///
        public String? PhoneNumber { get; set; }
        ///
        public String? FirstName { get; set; }
        ///
        public String? LastName { get; set; }
        ///
        public String? FullName { get; set; }
        ///
        public String? ProfilePictureUrl { get; set; }
        ///
        public String? Role { get; set; }
        ///
        public Boolean IsActive { get; set; }
        ///
        public DateTime CreatedAt { get; set; }
        ///
        public Nullable<DateTime> LastLoginAt { get; set; }
        ///
        public Nullable<DateTime> UpdatedAt { get; set; }
        //
        //public List<OrderCreateVM>? Orders { get; set; }
        ////
        //public List<TransactionCreateVM>? Transactions { get; set; }
        ////
        //public List<OperationCreateVM>? Operations { get; set; }
        ////
        //public List<EventCreateVM>? CreatedEvents { get; set; }
        ////
        //public List<ShoppingCartItemCreateVM>? ShoppingCart { get; set; }
        ////
        //public List<ProductReviewCreateVM>? ProductReviews { get; set; }
    }
}