using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoxelMMOShared;

namespace VoxelMMOServer
{
    public class SampleClass : IGamePacket
    {
        //Sample Class for testing the network interface
        public void OnGamePacketPack()
        {
            throw new System.NotImplementedException();
        }

        public void OnGamePacketParse()
        {
            throw new System.NotImplementedException();
        }
    }
}