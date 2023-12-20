using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class increasedecrease : MonoBehaviour
{
    float mutiplier;
    float mutiplierw;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
       mutiplier = rectTransform.sizeDelta.x / 100f;
        mutiplierw = rectTransform.transform.position.x / 100f;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void deacrease(int damage) {
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectTransform.sizeDelta.x - damage * mutiplier);
        rectTransform.transform.position = new Vector3(rectTransform.transform.position.x - (damage*(mutiplierw / 1.75f)) -4, rectTransform.transform.position.y, rectTransform.transform.position.z);

    }
    public void increase(int regenerate) {
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectTransform.sizeDelta.x + regenerate * 2);
        rectTransform.transform.position = new Vector3(rectTransform.transform.position.x + regenerate, rectTransform.transform.position.y, rectTransform.transform.position.z);

    }
}
