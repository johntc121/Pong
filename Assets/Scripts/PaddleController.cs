using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float paddleVelocity = 1f;
    public int player = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
       CheckInput(); 
    }


    void CheckInput() {
        float vertMove = Input.GetAxis("Vertical" + player);
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertMove * paddleVelocity);
    }
}
