using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movetoscene : MonoBehaviour
{
    [SerializeField] int nextscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void movescene()
    {
        SceneManager.LoadScene(nextscene);


    }
}
