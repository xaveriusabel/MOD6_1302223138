using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302223138
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeUser> uploadedvideo;
        public string username;

        public SayaTubeUser (string username)
        {
            this.username = username;
        }

        public int getTotalVideoPlayCount(SayaTubeUser user)
        {
            return this.uploadedvideo.Count;
        }

        public void addVideo(SayaTubeUser video) 
        { 
        
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User" + Username);
            for (int i = 0; i < this.uploadedvideo.Count; i++)
            {
                Console.Write("Video" + i + "Judul Film" + uploadedvideo[i]);
            }
        }


    }
}
