using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSizeUp : MonoBehaviour
{
    public Paddle rightPaddle;
    public Paddle leftPaddle;
    const int buffCount = 3;
    private void OnTriggerEnter(Collider other)
    {
        //do something interesting to the ball, paddle, or some other game element
        float ballDirection = other.gameObject.GetComponent<Rigidbody>().velocity.x;
        if (ballDirection > 0)
        {
            leftPaddle.buffCount = buffCount;
            leftPaddle.transform.localScale = new Vector3(1,1, 10);
        } else
        {
            rightPaddle.buffCount = buffCount;
            rightPaddle.transform.localScale = new Vector3(1, 1, 10);
        }
    }
}
