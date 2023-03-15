using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            RestartLevel();
            
        }
    }

    private void RestartLevel()
    {        
        AudioManager.instance.Play("Collision");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);       
    }
}
