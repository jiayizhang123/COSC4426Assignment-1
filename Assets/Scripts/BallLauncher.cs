using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class BallLauncher : MonoBehaviour
{
    [Header(" Elements")]
    [SerializeField] private Transform from;
    [SerializeField] private GameObject ballPrefab;

    [Header(" Settings")]
    [SerializeField] private Vector3 velocity;

    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("eddd");
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    LaunchBall();
        //}
    }

    public void LaunchBall()
    {
        //ball's velocity when launching
        velocity.x = Random.Range(-1f, 1f);
        velocity.y = Random.Range(3f, 7f);
        velocity.z = Random.Range(10f, 15f);
        //ball's launching position
        Vector3 p0 = from.position;
        p0.y = 1.2f; //height
        
        //create an balll instance
        GameObject ballInstance = Instantiate(ballPrefab,p0,Quaternion.identity,transform);
        //add velocity
        ballInstance.GetComponent<Rigidbody>().velocity = velocity;
    }
}
