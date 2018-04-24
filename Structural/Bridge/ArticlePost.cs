using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    public class ArticlePost : Post
    {
        public override void WritePost()
        {
            PostWriter.WriteContentPost(Title, Body);
        }
    }
}
