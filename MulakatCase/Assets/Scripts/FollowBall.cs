using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    // Update is called once per frame
    void Update()
    {
        MoveTowardsBall();
    }

    public void MoveTowardsBall()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
    }
}
