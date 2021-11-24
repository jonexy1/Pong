using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    private GameObject[] balls;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, Vector3.zero, Quaternion.identity);
    }

    void Update(){
        if(!ball){
            SpawnBall();
        }
    }

    public void SpawnBall(){
        float randX = Random.Range(-4.0f, 4.0f);
        balls = GameObject.FindGameObjectsWithTag("Ball");
        foreach(GameObject b in balls){
            Destroy(b);
        }
        Instantiate(ball, new Vector3(randX, 0, 0), Quaternion.identity);
    }
}
