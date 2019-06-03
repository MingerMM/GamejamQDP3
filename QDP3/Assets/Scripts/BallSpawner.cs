using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject greenBall;
    public GameObject yellowBall;
    public GameObject blueBall;
    public GameObject redBall;
    public GameObject pinkBall;

    private GameObject greenBallClone;
    private GameObject yellowBallClone;
    private GameObject blueBallClone;
    private GameObject redBallClone;
    private GameObject pinkBallClone;

    private Vector3 whereToSpawn;

    public float spawnRate = 2f;
    private float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector3(0, 5, 0);

            greenBallClone = Instantiate(greenBall, whereToSpawn, Quaternion.identity);
            yellowBallClone = Instantiate(yellowBall, whereToSpawn, Quaternion.identity);
            pinkBallClone = Instantiate(pinkBall, whereToSpawn, Quaternion.identity);
            redBallClone = Instantiate(redBall, whereToSpawn, Quaternion.identity);
            blueBallClone = Instantiate(blueBall, whereToSpawn, Quaternion.identity);

            greenBallClone.AddComponent<Rigidbody>();
            yellowBallClone.AddComponent<Rigidbody>();
            pinkBallClone.AddComponent<Rigidbody>();
            redBallClone.AddComponent<Rigidbody>();
            blueBallClone.AddComponent<Rigidbody>();
        }
    }
}
