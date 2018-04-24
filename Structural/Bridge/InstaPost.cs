using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public class InstaPost : IPostWriter
    {
        public void WriteContentPost(string title, string body)
        {
            Console.WriteLine("Instagram posting ..."); ;
            Console.WriteLine("IG Title: {0}", title);
            Console.WriteLine("IG Content: {0}", body);

        }
    }
}
