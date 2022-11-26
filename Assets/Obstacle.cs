using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    
   private void OnCollisionEnter (Collision collision)
    { 
    if (collision.gameObject.CompareTag("Player"))
        
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
}

}

