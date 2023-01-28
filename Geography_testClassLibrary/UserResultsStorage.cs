using Geography_testClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Geography_testClassLibrary
{
    public static class UserResultsStorage
    {
        public static string fileName = "results.json";
        public static void Safe(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Serialize(userResults);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(fileName))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(fileName);

            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        public static void Serialize(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(fileName, jsonData);
        }
    }
}