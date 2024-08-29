using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace ArrayString
{
    public class RedisSample
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("");
         public void AddToSet(string key, string value)
        {
            IDatabase db = redis.GetDatabase();
            db.SetAdd(new RedisKey(key), new RedisValue(value));
        }

        public string GetValueFromSet(string key) 
        {
            IDatabase db = redis.GetDatabase();
            RedisValue[] values =  db.SetMembers(new RedisKey(key));
            return values[0].ToString();


        }
    }
}
