using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    { 
    GameObject player = other.gameObject;
        if (player.CompareTag("player")) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(6);
        }
        
    }
    }
