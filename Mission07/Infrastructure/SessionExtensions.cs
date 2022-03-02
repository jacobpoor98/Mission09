using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Mission07.Infrastructure
{
    // create static class that will store session data
    public static class SessionExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        // check if there is session data and if there is, return it back
        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
