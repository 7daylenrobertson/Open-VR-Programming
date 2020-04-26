using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Vertical")*Time.deltaTime,0f,Input.GetAxis("Horizontal")*Time.deltaTime);

        //transform.Translate(0f,0f,-1f*Time.deltaTime);
    }
}
