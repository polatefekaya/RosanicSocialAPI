﻿using RosanicSocial.Domain.Data.Entities.Post;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Request.Comment {
    public class CommentDeleteRequest {
        public int PostId { get; set; }
        public int CommentId { get; set; }
    }
}
