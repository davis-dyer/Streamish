﻿using System.Collections.Generic;
using Streamish.Models;

namespace Streamish.Repositories
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile user);
        void Delete(int id);
        List<UserProfile> GetAll();
        UserProfile GetById(int id);
        void Update(UserProfile user);
        public UserProfile GetUserByIdWithVideosAndComments(int id);
        public List<UserProfile> GetAllUsersWithVideos();
    }
}
