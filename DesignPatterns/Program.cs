using Creational.Prototype;
using Structural.Bridge;
using Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /** ------- Prototype Pattern --------
             
                RigController rigController = new RigController();
                // Initialize with standard setup
                rigController["AMD"] = new Rig(Creational.Prototype.CpuType.AMD, 2, "FM2-55");
                rigController["Intel"] = new Rig(Creational.Prototype.CpuType.INTEL, 2, "H8DM1");
                rigController["Server"] = new Rig(Creational.Prototype.CpuType.INTEL, 4, "XE-45");


                // User clones selected setup
                Rig r1 = rigController["AMD"].Clone() as Rig;
                Rig r2 = rigController["Server"].Clone() as Rig;

                Console.ReadKey();
            */
            /** ------- Bridge Pattern -------- 
                IPostWriter twitter = new TweetPost();
                IPostWriter instagram = new InstaPost();

                Post post = new ArticlePost();
                post.Title = "The Title";
                post.Body = "The Body";

                post.PostWriter = twitter;
                post.WritePost();

                post.PostWriter = instagram;
                post.WritePost();

                Console.ReadKey();
*/
            /** ------- Facade Pattern -------- 
            Race race = new Race();
            Car car = new Car("Lykan");
            race.IsReady(car, 2);

            Console.ReadKey();
*/




        }  // end Main method
    } // end class Program
} // end namespace
