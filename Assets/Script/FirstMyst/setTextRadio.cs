using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setTextRadio : MonoBehaviour
{
    public Text myText;
    
    void Start()
    {
        myText = GetComponent<Text>();
    }


    public void SetMyText(float val)
    {
        myText.text = val.ToString("0.##");
    }
}
