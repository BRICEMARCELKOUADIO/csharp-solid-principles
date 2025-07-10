using ArdalisRating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_principles
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJosonString(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                throw new ArgumentException("JSON string cannot be null or empty.", nameof(jsonString));
            }
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Policy>(jsonString);
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                throw new InvalidOperationException("Failed to deserialize JSON string to Policy object.", ex);
            }
        }
    }
}
