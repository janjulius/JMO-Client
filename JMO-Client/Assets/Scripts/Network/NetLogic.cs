using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Network
{
    class NetLogic : MonoBehaviour, INetEventListener
    {
        private NetManager netManager;
        private NetDataWriter writer;
        private NetPacketProcessor packetProcessor;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            netManager = new NetManager(this)
            {
                AutoRecycle = true
            };
            netManager.Start();
            netManager.Connect(Settings.TARGET_END_POINT, Settings.PORT, Settings.CONNECTION_KEY);
        }

        private void Update()
        {
            netManager.PollEvents();
        }


        public void OnConnectionRequest(ConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            throw new NotImplementedException();
        }

        public void OnPeerConnected(NetPeer peer)
        {
            throw new NotImplementedException();
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            throw new NotImplementedException();
        }
    }
}
