using RosanicSocial.Domain.Data.Entities.Report;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Response.Reports.Ban {
    public class BanUpdateResponse {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int Category { get; set; }
        public bool IsCritical { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public static partial class UserBanEntityExtensions {
        public static BanUpdateResponse ToUpdateResponse(this UserBanEntity entity) {
            return new BanUpdateResponse {
                Id = entity.Id,
                UserId = entity.UserId,
                Category = entity.Category,
                IsCritical = entity.IsCritical,
                Reason = entity.Reason,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
