﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Webinex.Revoke.Stores
{
    /// <summary>
    ///     Revoke read store.
    /// </summary>
    public interface IRevokeReadStore
    {
        /// <summary>
        ///     Returns <c>True</c> if no matching <paramref name="ids"/> revokes
        ///     with time greater than or equal to <paramref name="issuedAt"/> found in store.
        ///     <c>False</c> otherwise.
        /// </summary>
        /// <param name="ids">RevokeIds to check</param>
        /// <param name="issuedAt">Time something was issue that need to be checked for revoke</param>
        /// <returns>See summary</returns>
        Task<bool> RevokedAnyAsync(IEnumerable<RevokeId> ids, DateTime issuedAt);
    }
}