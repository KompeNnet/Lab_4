﻿using Newtonsoft.Json;
using Lab_4.Books;

namespace Lab_4.Helpers
{
    public class Serializer
    {
        public static string Serialize(Book smth)
        {
            return JsonConvert.SerializeObject(smth);
        }

        public static dynamic Deserialize<T>(dynamic smth)
        {
            return JsonConvert.DeserializeObject<T>(smth);
        }
    }
}