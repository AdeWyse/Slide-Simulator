using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 1f);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Boolean wasReleased = collision.gameObject.GetComponent<Dragable>().ismoving;
        if (!wasReleased)
        {
            Destroy(collision.gameObject);

            //Check if count point and if counts subtract the specified amount
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        this.gameObject.transform.localScale = new Vector3(2f, 2f, 1f);
    }
}
