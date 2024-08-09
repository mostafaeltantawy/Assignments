using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV04.Youtube
{
    internal class subscriber
    {
        public string Name { get; set; }

        public void Notify(Video video , Channel channel)
        {
            Console.WriteLine($" {channel.ChannelName} is add new vidoe , {Name} \n {video} \n\n");
        }

        public override string ToString()
        {
            return $"Subscriber name: {Name}"; 
        }
    }
}
