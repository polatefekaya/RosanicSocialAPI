﻿using RosanicSocial.Application.Interfaces.Repository.Post;
using RosanicSocial.Domain.Data.Entities.Post;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Infrastructure.Repository
{
    public class CommentRepository : ICommentRepository {
        public Task<CommentEntity> AddComment(CommentEntity comment) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity> DeleteAllComments(int id) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity> DeleteComment(int id) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity[]> GetAllCommentsByPostId(int postId) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity[]> GetAllCommentsByUserId(int userId) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity> GetComment(int id) {
            throw new NotImplementedException();
        }

        public Task<CommentEntity> UpdateComment(CommentEntity comment) {
            throw new NotImplementedException();
        }
    }
}
