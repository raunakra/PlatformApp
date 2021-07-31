using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformApp
{
    public class PlatformFactory
    {
        public IPlatform GetPlatform(string platform)
        {
            switch (platform)
            {
                case KeyStore.Windows:
                    return new Windows();
                case KeyStore.Android:
                    return new Android();
                case KeyStore.Ios:
                    return new Ios();
                default:
                    throw new Exception("Invalid Platform");
            }
        }
    }
}
