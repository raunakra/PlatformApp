﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformApp
{
    class Windows : IPlatform
    {
        public string Message()
        {
            return string.Format(KeyStore.Message, KeyStore.Windows);
        }
    }
}
