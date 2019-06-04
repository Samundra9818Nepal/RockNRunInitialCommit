using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAT : MonoBehaviour
{
   public float FollowSpeed = 2f;
    public Transform Target; // player to follow



    // camera follows the player.
    private void Update()
    {
        Vector3 newPosition = Target.position;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}
