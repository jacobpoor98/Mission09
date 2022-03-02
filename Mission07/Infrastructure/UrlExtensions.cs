using System;
using Microsoft.AspNetCore.Http;

namespace Mission07.Infrastructure
{
    public static class UrlExtensions
    {
        // send the correct path to return to
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
