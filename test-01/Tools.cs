using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01
{
    public class Tools
    {
        public string GetNewhash() => Guid.NewGuid().ToString();
    }
}
