using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VoxelMMOShared;
//Preproccesor defines for the server side only code
//Build in server mode for this
#if UNITY_SERVER
public class ServerEntry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm the server");
        foreach(Type igp in System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(igp => igp.GetInterfaces().Contains(typeof(IGamePacket)))) { //Ling for finding the interface
            ((IGamePacket)Activator.CreateInstance(igp)).OnGamePacketPack(); //If the class isn't static then we need an instance reference or make a new instance
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
#endif