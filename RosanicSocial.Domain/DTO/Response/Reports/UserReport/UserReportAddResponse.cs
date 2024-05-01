using RosanicSocial.Domain.Data.Entities.Report;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Response.Reports.UserReport {
    public class UserReportAddResponse {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string? Reason { get; set; }
        public int ReportType { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
    public static partial class UserReportEntityExtensions {
        public static UserReportAddResponse ToAddResponse(this UserReportEntity entity) {
            return new UserReportAddResponse {
                Id = entity.Id,
                UserId = entity.UserId,
                Reason = entity.Reason,
                ReportType = entity.ReportType,
                CreatedAt = entity.CreatedAt
            };
        }
    }
}
