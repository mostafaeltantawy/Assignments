using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV04.Youtube
{
    internal class Channel
    {
        public string ChannelName { get; set; }
        public List<Video> Videos { get; set; }

        public void AddVideo(Video video)
        {
            Videos.Add(video);
            UploadVideo?.Invoke(video , this); 
        }

        public event Action<Video , Channel>? UploadVideo; 

        public override string ToString()
        {
            return $"Channel Name : {ChannelName}";
        }

        public Channel()
        {
            Videos = new List<Video>(); 
        }
    }
}
