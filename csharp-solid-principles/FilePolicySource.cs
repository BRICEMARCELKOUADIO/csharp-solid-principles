using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_principles
{
    public class FilePolicySource
    {
        public string GetPolicySource()
        {
            // Load policy from file
            return File.ReadAllText("policy.json");
        }
    }
}
