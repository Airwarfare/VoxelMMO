using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VoxelMMOShared
{
    public interface IGamePacket
    {
        //Pack = Taking info from the client and "packing" it into the packet to send to the server
        void OnGamePacketPack();

        //Parse = Taking info from the server and parsing the info to sync with the client
        void OnGamePacketParse();
    }
}
