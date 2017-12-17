using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web02
{
    public class Greeter : IGreeter
    {
        public Greeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public string GetGreetingText()
        {
            return $"Hello say '{Configuration["greeting:en"]}'";
        }
    }
}
