﻿using Organize.Shared.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organize.Shared.Contracts
{
    public interface IUserManager
    {
        Task<User> TrySignInAndGetUserAsync(User user);

        Task InsertUserAsync(User user);
    }
}
