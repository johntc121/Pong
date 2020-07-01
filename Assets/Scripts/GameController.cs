using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public GameObject spawn;
    public Text p1_ScoreText;
    public Text p2_ScoreText;
    public float scorePos = 7.1f;

    private Ball currentBall;
    private bool isActive = false;
    private int p1_score = 0;
    private int p2_score = 0; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBall != null) {
            if(currentBall.transform.position.x > scorePos) {
                p1_score++;
                Destroy(currentBall.gameObject);
                StartCoroutine(SpawnBall());
            }
            if(currentBall.transform.position.x < -scorePos) {
                p2_score++;
                Destroy(currentBall.gameObject);
        
                StartCoroutine(SpawnBall());
            }

            BallPosition();
        }

        
    }

    IEnumerator SpawnBall() {

        yield return new WaitForSeconds(2);
        isActive = true;
        GameObject ballInstance = Instantiate(ball, spawn.transform);
        currentBall = ballInstance.GetComponent<Ball>();
        //currentBall.transform.position = Vector3.zero;

        p1_ScoreText.text = p1_score.ToString();
        p2_ScoreText.text = p2_score.ToString();
    }

    public float BallPosition () {
        return currentBall.transform.position.y;
    }

    
}
