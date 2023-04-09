﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Webinex.Revoke.Middleware
{
    public interface IRevokeAccessor
    {
        Task<IEnumerable<RevokeId>> GetAsync(HttpContext context);
    }
}