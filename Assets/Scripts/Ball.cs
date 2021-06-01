using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public delegate void BallDie();
    public BallDie ballDie;
    [SerializeField] Player player;
    public bool isMoving { get; set; }
    void Start()
    {
        player.ballController += SwitchState;
    }

    void Update()
    {
        
    }

    void SwitchState(){
        isMoving = !isMoving;
    }

    void OnDisable(){
        player.ballController -= SwitchState;
    }
}
