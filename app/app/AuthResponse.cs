using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class AuthResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public string token { get; set; }
    }
}

