using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDemo.Services
{
    class HttpServices
    {
        public static readonly HttpClient client = new()
        {
            BaseAddress = new Uri("https://thesampleapi.com/")
        };
    }
}
