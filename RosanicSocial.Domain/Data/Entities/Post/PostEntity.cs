﻿using System.ComponentModel.DataAnnotations;

namespace RosanicSocial.Domain.Data.Entities.Post
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Category { get; set; } = 0;
        public int? Type { get; set; } = null;
        public int? Topic { get; set; } = null;
        public string? Body { get; set; } = null;
        public int LikeCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public string? MediaUrl { get; set; } = null;
        public int MediaType { get; set; } = 0;
        public bool IsUpdated { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public bool IsArchived { get; set; } = false;
        public bool IsPromoted { get; set; } = false;
        public bool IsNSFW { get; set; } = false;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
