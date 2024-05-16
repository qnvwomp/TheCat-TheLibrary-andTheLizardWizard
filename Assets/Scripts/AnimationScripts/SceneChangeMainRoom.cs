using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeMainRoom : MonoBehaviour
{
    public string Observatory; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that triggered the event is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(Observatory);
        }
    }
}
