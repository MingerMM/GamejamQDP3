using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickBallUpScore : MonoBehaviour
{

    private int MissionNumber = 1;
    private int BallsCollected = 0;

    private float score = 0f;

    public AudioSource ping;

    public GameObject textBlue;
    public GameObject textGreen;
    public GameObject textPink;
    public GameObject textYellow;
    public GameObject textRed;
    public GameObject textWin;
    public GameObject textLose;

    private float timer;
    public Text timerDisplay;
    private float offset;
    private float elapsedTime;

    //MissionNumber 1 = blue, 2 = green, 3 = pink, 4 = yellow, 5 = red

    // Start is called before the first frame update
    void Start()
    {
      offset = Time.time;  
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime = Time.time - offset;
        timer = 100.0f - elapsedTime;
        timerDisplay.text = timer.ToString("F1");

        if (MissionNumber == 1)
        {
            textBlue.SetActive (true);
        }
        if (MissionNumber == 2)
        {
            textBlue.SetActive(false);
            textGreen.SetActive(true);
        }
        if (MissionNumber == 3)
        {
            textGreen.SetActive(false);
            textPink.SetActive(true);
        }
        if (MissionNumber == 4)
        {
            textPink.SetActive(false);
            textYellow.SetActive(true);
        }
        if (MissionNumber == 5)
        {
            textYellow.SetActive(false);
            textRed.SetActive(true);
        }
        if (MissionNumber == 6)
        {
            textRed.SetActive(false);
            textWin.SetActive(true);

            if (Input.GetKeyDown ("space"))
                {
                SceneManager.LoadScene("SampleScene");
                //offset = 0f;
                elapsedTime = 0;
            }
        }
        if ((timer < 0.0f) && (MissionNumber < 6))
        {
            textBlue.SetActive(false);
            textGreen.SetActive(false);
            textPink.SetActive(false);
            textYellow.SetActive(false);
            textRed.SetActive(false);
            textWin.SetActive(false);
            textLose.SetActive(true);

            if (Input.GetKeyDown("space"))
                {
                SceneManager.LoadScene("SampleScene");
                //offset = 0;
                elapsedTime = 0;
            }

        }
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name);

        if ((other.gameObject.tag == "Blue") && (MissionNumber == 1))
        {
            Destroy(other.gameObject);
            BallsCollected += 1;
            ping.Play();
            Debug.Log("Blue Ball added to total");
        }
        if ((other.gameObject.tag == "Green") && (MissionNumber == 2))
        {
            Destroy(other.gameObject);
            BallsCollected += 1;
            ping.Play();
            Debug.Log("Green Ball added to total");
        }
        if ((other.gameObject.tag == "Pink") && (MissionNumber == 3))
        {
            Destroy(other.gameObject);
            BallsCollected += 1;
            ping.Play();
            Debug.Log("Pink Ball added to total");
        }
        if ((other.gameObject.tag == "Yellow") && (MissionNumber == 4))
        {
            Destroy(other.gameObject);
            BallsCollected += 1;
            ping.Play();
            Debug.Log("Yellow Ball added to total");
        }
        if ((other.gameObject.tag == "Red") && (MissionNumber == 5))
        {
            Destroy(other.gameObject);
            BallsCollected += 1;
            ping.Play();
            Debug.Log("Red Ball added to total");
        }

        if (BallsCollected == 10)
        {
            MissionNumber += 1;
            BallsCollected = 0;
            score += 1;
            Debug.Log("Point added to score");
        }
        
        
    }
}
