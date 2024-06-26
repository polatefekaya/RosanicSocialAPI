﻿using RosanicSocial.Domain.Data.Entities.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RosanicSocial.Domain.DTO.Request.Comment {
    public class CommentAddRequest {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int? RepliedUserId { get; set; }
        public int? RepliedCommentId { get; set; }
        public string Body { get; set; } = string.Empty;
        public bool IsReply { get; set; } = false;

        public CommentEntity ToEntity() {
            return new CommentEntity {
                PostId = PostId,
                UserId = UserId,
                Body = Body,
                RepliedUserId = RepliedUserId,
                RepliedCommentId = RepliedCommentId,
                IsReply = IsReply
            };
        }
    }
}
