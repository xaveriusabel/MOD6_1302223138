using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302223138
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public  SayaTubeVideo(string title)
        {
            if (title == null || title == "")
            {
                throw new ArgumentException("Title cannot be null or empty");
            }
            Random r = new Random();
            this.id = r.Next(10000, 99999);
            this.title = title;
            this.PlayCount = PlayCount;
        }
        public void incrementPlayCount(int x)
        {
            try
            {
                checked
                {
                    if (x > 10000000)
                    {
                        PlayCount += 10000000;
                    }
                    else
                    {
                        PlayCount += x;
                    }

                }
            }
            catch (OverflowException e)
            {
                this.PlayCount = int.MaxValue;
                Console.WriteLine("Play count is too high to increment \n");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + PlayCount);
        }
    }
}

    }

}
