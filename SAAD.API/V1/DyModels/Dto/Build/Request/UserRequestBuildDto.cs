using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Requests
{
    public class UserRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public String? UserId { get; set; }
        /// <summary>
        /// Username property for DTO.
        /// </summary>
        public String? Username { get; set; }
        /// <summary>
        /// Email property for DTO.
        /// </summary>
        public String? Email { get; set; }
        /// <summary>
        /// PasswordHash property for DTO.
        /// </summary>
        public String? PasswordHash { get; set; }
        /// <summary>
        /// PhoneNumber property for DTO.
        /// </summary>
        public String? PhoneNumber { get; set; }
        /// <summary>
        /// FirstName property for DTO.
        /// </summary>
        public String? FirstName { get; set; }
        /// <summary>
        /// LastName property for DTO.
        /// </summary>
        public String? LastName { get; set; }
        /// <summary>
        /// FullName property for DTO.
        /// </summary>
        public String? FullName { get; set; }
        /// <summary>
        /// ProfilePictureUrl property for DTO.
        /// </summary>
        public String? ProfilePictureUrl { get; set; }
        /// <summary>
        /// Role property for DTO.
        /// </summary>
        public String? Role { get; set; }
        /// <summary>
        /// IsActive property for DTO.
        /// </summary>
        public Boolean IsActive { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// LastLoginAt property for DTO.
        /// </summary>
        public Nullable<DateTime> LastLoginAt { get; set; }
        /// <summary>
        /// UpdatedAt property for DTO.
        /// </summary>
        public Nullable<DateTime> UpdatedAt { get; set; }
        public ICollection<OrderRequestBuildDto>? Orders { get; set; }
        public ICollection<TransactionRequestBuildDto>? Transactions { get; set; }
        public ICollection<OperationRequestBuildDto>? Operations { get; set; }
        public ICollection<EventRequestBuildDto>? CreatedEvents { get; set; }
        public ICollection<ShoppingCartItemRequestBuildDto>? ShoppingCart { get; set; }
        public ICollection<ProductReviewRequestBuildDto>? ProductReviews { get; set; }
    }
}