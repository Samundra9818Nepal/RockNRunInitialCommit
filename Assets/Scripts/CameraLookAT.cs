using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAT : MonoBehaviour
{
   public float SmoothSpeed = 2f;
    public Transform Target; // player to follow
    public Vector3 OffSet;



    // camera follows the player.
    private void FixedUpdate()
    {
        Vector3 newPosition = Target.position + OffSet;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, newPosition, SmoothSpeed * Time.deltaTime);
        transform.position = SmoothPosition;
       // newPosition.z = -10;
        //transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}
