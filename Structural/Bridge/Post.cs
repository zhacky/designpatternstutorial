using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public abstract class Post
    {
        public IPostWriter PostWriter { get; set; }
        public string Title  { get; set; }
        public string Body { get; set; }

        public abstract void WritePost();
    }
}
