using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 150.0f * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * 3.0f * Time.deltaTime;
        transform.Rotate(new Vector3(0,x,0));
        transform.Translate(new Vector3(0, 0, z));
    }
}
