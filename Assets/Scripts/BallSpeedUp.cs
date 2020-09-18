using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedUp : MonoBehaviour
{
    const int amplitude = 100;
    private void OnTriggerEnter(Collider collider)
    {
            var rb = collider.gameObject.GetComponent<Rigidbody>();
            if(rb.velocity.x > 0)
            {
                rb.AddForce(new Vector3(amplitude, 0, 0));
            } else
            {
                rb.AddForce(new Vector3(-1 * amplitude, 0, 0));
            }

    }
}
