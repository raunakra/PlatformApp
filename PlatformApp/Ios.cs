using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformApp
{
    public class Ios : IPlatform
    {
        public string Message()
        {
            return string.Format(KeyStore.Message, KeyStore.Ios);
        }
    }
}
