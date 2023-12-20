using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume : MonoBehaviour
{
    [SerializeField ] pausemenu pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resumegame() {

        pausemenu.resumegame();
    }
}
