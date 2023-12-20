using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    private bool ispaused =false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                resumegame();
                ispaused = false;
            }
            else
            {
                pausegame();
                ispaused = true;
            }
        }
    }
    public void pausegame() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;

    }

    public void resumegame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
