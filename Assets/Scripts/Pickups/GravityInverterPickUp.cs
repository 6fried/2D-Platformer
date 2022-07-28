using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityInverterPickUp : Pickup
{
    public GravityState gravitState = null;
    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Rigidbody2D body = collision.GetComponent<Rigidbody2D>();
            body.gravityScale *= -1;
            Transform playerTransform = collision.GetComponent<Transform>();
            playerTransform.Rotate(new Vector3(180, 0, 0));
            gravitState.isGravityInverted = !gravitState.isGravityInverted;
            base.DoOnPickup(collision);
        }
    }
}
