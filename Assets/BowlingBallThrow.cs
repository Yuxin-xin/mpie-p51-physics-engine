using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BowlingBallThrow : MonoBehaviour
{
    public float throwPower = 500f;
    public float positionRange = 5f;
    public float maxThrowPower = 1000f;
    public float minThrowPower = 100f;
    public float rotationSpeed = 10f;
    private Rigidbody rb;
    private float currentThrowPower;
    private Vector3 startPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentThrowPower = throwPower;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float positionChange = Input.GetAxis("Horizontal")*positionRange*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space)){
            ThrowBall();
        }
        
    }

    void ThrowBall()
    {
        rb.AddForce(Vector3.back*throwPower);
    }
}
