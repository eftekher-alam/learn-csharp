using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicInharitance
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        public int VideoSize { get; set; }
        public int VideoLength { get; set; }

        public VideoPost()
        {
            VideoSize = 0;
            VideoLength = 0;
            Title = "Default Video Post Title";
            UserName = "Default Video User Name";
        }
        //In C#, there is no need to call base class constructor for pass parameters
        public VideoPost(int size, int length, string title, string userName)
        {
            this.VideoSize = size;
            this.VideoLength = length;
            this.Title = title;
            //this.UserName = userName; //It will take default user name
        
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video is playing.");
                timer = new Timer(TimerCallback, null, 0, 500);  
            }
            else
            {
                Stop();
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at " + currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stoped at " + currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return "=======> Post from derived class(Video) <=========" + "\nPost Id : " + PostID + "\nTitle : " + Title + "\nUser Name : " + UserName + "\nVideo Length : " + VideoSize + "\nVideo Length : " + VideoLength;
        }
    }
}