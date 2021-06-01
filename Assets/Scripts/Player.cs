using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movementVelocity = 20f;
    Vector3 newPosition;
    [SerializeField] int lifes = 3;
    [SerializeField] Ball ball;
    public delegate void ImDie();
    public ImDie playerDie;
    public delegate void BallController();
    public BallController ballController;
    void Start()
    {
        ball.ballDie += IsBallDie;
    }

    void Update()
    {
        Movement();
        FreeBall();
    }

    void Movement(){
        float zAxis = Input.GetAxis("Horizontal");
        newPosition = new Vector3(zAxis * movementVelocity * Time.deltaTime, 0f, 0f);
        transform.position += newPosition;
    }

    void FreeBall(){
        if(!ball.isMoving){
            if(Input.GetKeyDown(KeyCode.Space)){
                ballController();
            }
        }
    }

    void IsBallDie(){
        lifes--;
        if(lifes <= 0){
            playerDie();
        }
    }

    void OnDisable(){
        ball.ballDie -= IsBallDie;
    }
}
