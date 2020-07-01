using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float difficultyMultiplier = 1.0f;
    public float minXSpeed = 0.8f;
    public float maxXSpeed = 1.2f;
    public float minYSpeed = 0.8f;
    public float maxYSpeed = 1.2f;

    private Rigidbody2D ballRigidbody;

    void Start(){
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.velocity = 
            new Vector2(
                Random.Range(minXSpeed, maxXSpeed)*(Random.value > 0.5f ? -1 : 1), 
                Random.Range(minYSpeed,maxYSpeed)*(Random.value > 0.5f ? -1 : 1)
            );
    }
    void OnTriggerEnter2D (Collider2D otherCollider) {
        if(otherCollider.tag == "UpperBound"){
            GetComponent<AudioSource>().Play();

            ballRigidbody.velocity = 
                new Vector2(ballRigidbody.velocity.x, -ballRigidbody.velocity.y);
        }

        else if(otherCollider.tag == "LowerBound"){
            GetComponent<AudioSource>().Play();
            ballRigidbody.velocity = 
                new Vector2(ballRigidbody.velocity.x, -ballRigidbody.velocity.y);
        }

        else if(otherCollider.tag == "Paddle"){
            GetComponent<AudioSource>().Play();
            ballRigidbody.velocity = 
                new Vector2(-ballRigidbody.velocity.x * difficultyMultiplier, ballRigidbody.velocity.y * difficultyMultiplier);
        }

    }

}
