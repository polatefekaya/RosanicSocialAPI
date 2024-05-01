using RosanicSocial.Domain.Data.Entities.Report;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Response.Reports.Post {
    public class PostReportUpdateResponse {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string? Reason { get; set; }
        public int ReportType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public static partial class PostReportEntiyExtensions {
        public static PostReportUpdateResponse ToUpdateResponse(this PostReportEntity entity) {
            return new PostReportUpdateResponse {
                Id = entity.Id,
                UserId = entity.UserId,
                PostId = entity.PostId,
                Reason = entity.Reason,
                ReportType = entity.ReportType,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
