﻿using RosanicSocial.Domain.Data.Entities.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace RosanicSocial.Domain.DTO.Request.Likes.Comment {
    public class CommentLikesGetAllByUserIdRequest {
        public int UserId { get; set; }
    }
}
