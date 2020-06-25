using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore_ViewInjection.Services
{
    public class TimesService
    {
        public List<string> GetTimes()
        {
            return new List<string>() { "Corinthins1", "Corinthins2", "Corinthins3" };
        }
    }
}
