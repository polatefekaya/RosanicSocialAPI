﻿using RosanicSocial.Domain.Data.Entities;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Domain.DTO.Request.Info.Base {
    public class BaseInfoAddRequest {
        public int UserId { get; set; }
        public int PostCount { get; set; }
        public int? FollowerCount { get; set; }
        public int? FollowingCount { get; set; }
        public bool IsPrivate { get; set; } = false;
        public DateTime? Birthday { get; set; }
        public BaseInfoEntity ToEntity() {
            return new BaseInfoEntity {
                UserId = UserId,
                PostCount = PostCount,
                FollowerCount = FollowerCount,
                FollowingCount = FollowingCount,
                IsPrivate = IsPrivate,
                Birthday = Birthday
            };
        }
    }
}
