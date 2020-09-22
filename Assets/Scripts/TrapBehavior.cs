using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehavior : MonoBehaviour
{
    public Vector3 horizontal;
    public Vector3 vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-horizontal); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(horizontal);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(vertical);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-vertical);
        }
    }
}
