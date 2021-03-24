using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace SecondHand.Models
{
    public static class Sessions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value, Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }));
            /*session.SetString(key, JsonConvert.SerializeObject(value));*/
        }

        public static T GetObjectFromJson<T>(this ISession session, string key){
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public static int returnCount(this ISession session) {
            List<Products> _sessionList = Sessions.GetObjectFromJson<List<Products>>(session, "cart");
            return (_sessionList != null ? _sessionList.Count() : 0);
        }
    }
}
