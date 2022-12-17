using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Share;

namespace DotNetServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8085);
            ChannelServices.RegisterChannel(ch);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CustomService),"rahul", WellKnownObjectMode.Singleton);
            Console.Write("Sever is  Ready........");
            Console.Read();
        }
    }
}
