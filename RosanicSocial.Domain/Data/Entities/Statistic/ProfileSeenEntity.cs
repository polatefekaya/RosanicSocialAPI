﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RosanicSocial.Domain.Data.Entities.Statistic {
    public class ProfileSeenEntity {
        [Key]
        public int UserId { get; set; }
        public int SeenUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
