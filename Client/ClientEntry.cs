using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if !UNITY_SERVER
public class ClientEntry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm the client");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
#endif