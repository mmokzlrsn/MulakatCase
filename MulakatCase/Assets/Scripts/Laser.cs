using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    [SerializeField] private bool isDangerous = true;
    
    public void ChangeDanger()
    {
        if (isDangerous)
            isDangerous = false;
        else
            isDangerous = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && isDangerous)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload current scene
        }

        if (other.gameObject.CompareTag("Player") && !isDangerous)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.UpdateScore();
                
            }
        }
 
    }
}
