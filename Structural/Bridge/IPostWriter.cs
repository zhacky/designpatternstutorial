﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public interface IPostWriter
    {
        void WriteContentPost(string title, string body);
    }
}
