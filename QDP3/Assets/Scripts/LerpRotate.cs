using UnityEngine;
using System.Collections;

public class LerpRotate : MonoBehaviour
{
    public float Rotation_Speed;
    public float Rotation_Friction; //The smaller the value, the more Friction there is. [Keep this at 1 unless you know what you are doing].
    public float Rotation_Smoothness; //Believe it or not, adjusting this before anything else is the best way to go.

    private Quaternion Quaternion_Rotate_From;
    private Quaternion Quaternion_Rotate_To;

    private float rangeRotation1;
    private float rangeRotation2;
    private float rangeRotation3;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        rangeRotation1 = Random.Range(-15f, 15f);
        rangeRotation2 = Random.Range(-15f, 15f);
        rangeRotation3 = Random.Range(-15f, 15f);
    }

    // Update is called once per frame
    public void Rotate()
    {



        Quaternion_Rotate_From = transform.rotation;
        Quaternion_Rotate_To = Quaternion.Euler(rangeRotation1, rangeRotation2, rangeRotation3);

        transform.rotation = Quaternion.Lerp(Quaternion_Rotate_From, Quaternion_Rotate_To, Time.deltaTime * Rotation_Smoothness);
    }
}
