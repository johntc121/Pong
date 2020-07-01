using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour

{

    public GameObject ball;
    public GameObject AI_Paddle;

    public GameController gameController;
    public float AI_Speed = 5.0f;

    Vector2 paddle;
    // Start is called before the first frame update

    
    void Start()
    {
        paddle = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if(gameController.BallPosition() < transform.position.y){
        //     //AI_Paddle.transform.position.y += AI_Speed;
        //     transform.position = new Vector2(transform.position.x, transform.position.y + AI_Speed);
        //     //  paddle.y += AI_Speed;
        //     Debug.Log("Below");
            
        // }
        // if(gameController.BallPosition() > transform.position.y){
        //     //AI_Paddle.transform.position.y += AI_Speed;
        //     transform.position = new Vector2(transform.position.x, transform.position.y - AI_Speed);
        //     //  paddle.y -= AI_Speed;
        //     Debug.Log("Above");
            
        //  }
        Debug.Log(transform.position.y);
    }
}
