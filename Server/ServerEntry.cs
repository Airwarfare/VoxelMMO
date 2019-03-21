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
        foreach(var igp in System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(igp => igp.GetInterfaces().Contains(typeof(IGamePacket)))) {
            Debug.Log(igp.FullName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
#endif