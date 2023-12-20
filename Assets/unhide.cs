using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unhide : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject controlMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void unhidecanvas()
    {
        controlMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void hidecanvas()
    {
        controlMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
