﻿using MobaShared.Auth;
using System.Threading.Tasks;

namespace MobaClient.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
