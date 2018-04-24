using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public class TweetPost : IPostWriter
    {
        public void WriteContentPost(string title, string body)
        {
            Console.WriteLine("Tweeting...");
            Console.WriteLine("Tweet Title: {0}", title);
            Console.WriteLine("Tweet Content: {0}", body);

        }
    }
}
