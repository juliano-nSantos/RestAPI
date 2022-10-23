using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services.Extensoes
{
    public static class Extensions
    {
        public static string RemovePontosTracosBarras(this string value)
        {
            var newValue = string.Empty;

            if (!string.IsNullOrEmpty(value))
                newValue = value.Replace(".", "").Replace("/", "").Replace("-", "");

            return newValue;
        }        
    }
}
