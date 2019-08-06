using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAT : MonoBehaviour
{



    private float SmoothSpeed = 8f;
    public Transform Target; // player to follow
    public Vector3 OffSet;

    private void Start()
    {
        

        SmoothSpeed = 8f;
    }


    // camera follows the player.
    private void FixedUpdate()
    {
       //vector3 OffSet = new Vector3(6.3f, 1.5f, -5.3f);
        Vector3 newPosition = Target.position + OffSet;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, newPosition, SmoothSpeed * Time.deltaTime);
        transform.position = SmoothPosition;
        // newPosition.z = -10;
        //transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}
    
