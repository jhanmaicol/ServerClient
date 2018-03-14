using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bindings;

namespace CSharpClient
{
    class ClientHandleNetworkData
    {
        private delegate void Packet_(byte[] data);
        private static Dictionary<int, Packet_> Packets;

        public static void InitializeNetworkPakages()
        {
            Console.WriteLine("Initialize Network Pakages");
            Packets = new Dictionary<int, Packet_>
            {
                {(int)ServerPackets.SConnectionOK, HandleConnectionOK }
            };
        }

        public static void HandleNetworkInfromation(byte[] data)
        {
            int packetnum; PaketBuffer buffer = new PaketBuffer();
            buffer.WriteBytes(data);
            packetnum = buffer.ReadInteger();
            buffer.Dispose();
            if(Packets.TryGetValue(packetnum,out Packet_ Packet))
            {
                Packet.Invoke(data);
            }
        }
        private static void HandleConnectionOK(byte[] data)
        {
            PaketBuffer buffer = new PaketBuffer();
            buffer.WriteBytes(data);
            int packenum = buffer.ReadInteger();
            String msg = buffer.ReadString();
            buffer.Dispose();

            //add your code you wnat to excute here:
            Console.WriteLine(msg);
        }
    }
}
