using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDisabled : MonoBehaviour
{



    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player" )
        {

            this.GetComponent<PolygonCollider2D>().enabled = false;

        }

    }
}
