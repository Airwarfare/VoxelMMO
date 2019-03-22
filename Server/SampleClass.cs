using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VoxelMMOShared;

namespace VoxelMMOServer
{
    public class SampleClass : IGamePacket
    {
        //Sample Class for testing the network interface
        //This will be removed in production, only on DEBUG builds
        public void OnGamePacketPack()
        {
            Debug.LogWarning("This works!");
            return;
        }

        public void OnGamePacketParse()
        {
            throw new System.NotImplementedException();
        }
    }
}