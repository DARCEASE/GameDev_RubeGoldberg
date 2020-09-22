using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenHit : MonoBehaviour
{
    public GameObject jointLatch;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter2D(Collider2D joint)
    {
     
            Debug.Log("Im collididng with this!");
            Destroy(jointLatch);
  
    }

} 
