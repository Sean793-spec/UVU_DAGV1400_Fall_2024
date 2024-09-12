using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TransformController : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, length:3); 
        var p = new Vector3(x:0, y:x, z:0);
        transform.position = p;
        
        transform.Rotate(eulers:new Vector3(x:0, y:30, z:0) * Time.deltaTime);
    }

    
}
