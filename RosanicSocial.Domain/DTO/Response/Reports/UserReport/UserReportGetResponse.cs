using RosanicSocial.Domain.Data.Entities.Report;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Response.Reports.UserReport {
    public class UserReportGetResponse {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string? Reason { get; set; }
        public int ReportType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public static partial class UserReportEntityExtensions {
        public static UserReportGetResponse ToGetResponse(this UserReportEntity entity) {
            return new UserReportGetResponse {
                Id = entity.Id,
                UserId = entity.UserId,
                Reason = entity.Reason,
                ReportType = entity.ReportType,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
