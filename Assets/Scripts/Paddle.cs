using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public AudioClip hitSound;

    public AudioClip mediumSound;

    public AudioClip fastSound;

    public AudioSource speaker;

    public int buffCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Ball"))
        {
            var rb = collision.gameObject.GetComponent<Rigidbody>();
            float ballSpeed = Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z);
            if (ballSpeed > 20)
            {
                this.FastSound();
            }
            else if (ballSpeed > 15)
            {
                this.MediumSound();
            }
            else
            {
                this.NormalSound();
            }

            if (buffCount > 0)
            {
                buffCount--;
                if(buffCount == 0)
                {
                    this.transform.localScale = new Vector3(1, 1, 5);
                }
            }
        }
    }

    public void NormalSound()
    {
        speaker.PlayOneShot(hitSound);
    }

    public void MediumSound()
    {
        speaker.PlayOneShot(mediumSound);
    }

    public void FastSound()
    {
        speaker.PlayOneShot(fastSound);
    }    
}
