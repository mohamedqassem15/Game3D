using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class collect : MonoBehaviour
{
    private int coin = 0;
    public TextMeshProUGUI ctext;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "coin")
        {
            coin++;
            ctext.text = "Coins Collected: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }
}
