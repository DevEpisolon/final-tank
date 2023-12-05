using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode; 

public class MoveTurret : NetworkBehaviour
{
    // Start is called before the first frame update
     public float spinSpeed = 90.0f; 
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }

        
    }
}
