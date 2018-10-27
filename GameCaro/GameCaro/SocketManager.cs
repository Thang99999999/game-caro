﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameCaro
{
    public class SocketManager
    {
        #region Client
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ie);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        #endregion
        #region server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ie);
            server.Listen(10);
            Thread acceptClient = new Thread(() => 
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        #endregion
        #region Both
        public string IP = "132.2.0.1";
        public int PORT = 9999;
        public const int BUFFER = 1024;
        public bool isServer = true;
        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
            
            return SendData(client, sendData);
            
            
        }
        public object Receive()
        {
            byte[] receiveData = new byte[BUFFER];
            bool isOK = ReceiveData(client,receiveData);

            return DeserializeData(receiveData); 
        }
        private bool SendData(Socket target,byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }
        private bool ReceiveData(Socket target,byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();

        }
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf = new BinaryFormatter();
            ms.Position = 0;
            return bf.Deserialize(ms);
        }
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if(item.NetworkInterfaceType== _type && item.OperationalStatus==OperationalStatus.Up)
                {
                    foreach(UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if(ip.Address.AddressFamily==AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion
    }
}
