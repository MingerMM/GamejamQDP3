using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSurface : MonoBehaviour
{
    public GameObject surface;

    private Quaternion targetRotation;
    private Quaternion currentRotation;

    private Transform rotation1;
    private Transform rotation2;
    private Transform rotation3;

    private float rangeRotation1;
    private float rangeRotation2;
    private float rangeRotation3;

    public float startTime;
    public float elapsedTime;

    private bool canRotate;




    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        canRotate = false;

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        elapsedTime = Time.time - startTime;

        //rangeRotation1 = Random.Range(-15f, 15f);
        //rangeRotation2 = Random.Range(-15f, 15f);
        // rangeRotation3 = Random.Range(-15f, 15f);

        //rotation1.transform.rotation = new Vector3(rangeRotation1, rangeRotation2, rangeRotation3);

        //rotation1.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        if (canRotate = true)
        {
            targetRotation = Quaternion.Euler(rangeRotation1, rangeRotation2, rangeRotation3);
            surface.transform.rotation = Quaternion.Lerp(surface.transform.rotation, targetRotation, elapsedTime * speed);
            Debug.Log("rotated smoothly");

            

            canRotate = false;
            Debug.Log("canRotate = false");
            
            
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag == "Button")
        {
            Debug.Log("found if statement");

            //surface.transform.Rotate(rangeRotation1, rangeRotation2, rangeRotation3);  werkt, geen lerp
            //surface.transform.rotation = Quaternion.Lerp(transform.rotation, rangeRotation1, speed * Time.deltaTime);
            //surface.transform.Rotate = Quaternion.Lerp(from.rotation, rotation1.rotation, Time.time * speed);
            //surface.transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * smooth);

            //surface.transform.rotation = Quaternion.Euler(rangeRotation1, rangeRotation2, rangeRotation3);  //werkt geen lerp

            rangeRotation1 = Random.Range(-20f, 20f);
            rangeRotation2 = Random.Range(-20f, 20f);
            rangeRotation3 = Random.Range(-20f, 20f);

            startTime = Time.time;

            canRotate = true;

            //currentRotation = surface.transform.rotation;
            //targetRotation = Quaternion.Euler(rangeRotation1, rangeRotation2, rangeRotation3);
            //surface.transform.rotation = Quaternion.Lerp(surface.transform.rotation, targetRotation, Time.time * speed);   // Slerp or Lerp doesnt change anything
            //surface.GetComponent<LerpRotate>().Rotate();

            Debug.Log("Rotated");
        }
        else
        {
            canRotate = false;
        }
    }
}
