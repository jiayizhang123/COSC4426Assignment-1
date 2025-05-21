using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlerAnimator : MonoBehaviour
{
    [Header(" Elements")]
    [SerializeField] private Bowler bowler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Throwball()
    {
        bowler.ThrowBall();
    }
}
