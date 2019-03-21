using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Preproccesor defines for the server side only code
//Build in server mode for this
#if UNITY_SERVER
public class ServerEntry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm the server");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
#endif