﻿using JWTRefreshToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTRefreshToken.IService
{
    public interface IUserServiceRepository
    {
        Task<bool> IsValidUserAsync(Users users);
        UserRefreshTokens AddUserRefreshTokens(UserRefreshTokens user);
        UserRefreshTokens GetSavedRefreshTokens(string username, string refreshtoken);
        void DeleteUserRefreshTokens(string username, string refreshToken);
        int SaveCommit();
    }
}
