using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehavior : MonoBehaviour
{
    public Transform cameraTransform;
    Transform cameraFocusTarget;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D activator)
    {
        Debug.Log(activator.name + "entered this Trigger!");
        cameraFocusTarget = activator.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraFocusTarget != null)
        {
            cameraTransform.position = cameraFocusTarget.position + new Vector3(0f,0f,-10f);

        }
    }
}
