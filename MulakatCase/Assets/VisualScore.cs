using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualScore : MonoBehaviour, ICanMove
{
    private float moveSpeed;
    [SerializeField] private Transform scoreText;
    private Vector3 startPosition;
    
    private float desiredDuration = 1f;
    private float elapsedTime;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        MoveTowardsScoreText();
    }

    public void MoveTowardsScoreText()
    {
        gameObject.SetActive(true);
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;

        transform.position = Vector3.Lerp(startPosition, scoreText.position, percentageComplete);

        if(transform.position == scoreText.transform.position)
        {
            elapsedTime = 0;
            gameObject.SetActive(false);
            transform.position = new Vector3(0, 0, 0);
        }
    }

    public float GetSpeed()
    {
        return moveSpeed;
    }
     

    public void SetSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
}
