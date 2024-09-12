using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 100f;

    public float xrotationSpeed = 30f;
    public string MyMom = "Your Mom";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle: xrotationSpeed * Time.deltaTime,yAngle: rotationSpeed * Time.deltaTime,zAngle: rotationSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
        transform.Rotate(new Vector3(30, 0, 0) * Time.deltaTime);
        var x = Mathf.PingPong(Time.time, 3); transform.position = new Vector3(x, 0, 0);
        Debug.Log(message:"MyMom");
        
    }

    void resetScene()
    {
        SceneManager.LoadScene(0);
    }
    
}

