using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowler : MonoBehaviour
{
    
    [Header(" Elements")]
    [SerializeField] private Animator animator;
    [SerializeField] private BallLauncher ballLauncher;
    [SerializeField] private AudioSource throwingBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //throwing ball
    public void ThrowBall()
    {
        Debug.Log("Throwing");
        ballLauncher.LaunchBall();
        throwingBall.Play();
    }
}
