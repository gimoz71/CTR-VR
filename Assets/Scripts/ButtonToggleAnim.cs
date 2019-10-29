using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToggleAnim : MonoBehaviour
{
    private bool toggleState = true;
    private bool toggleStart = true;

    public Animator object1;
    public Text label;


    // Use this for initialization
    void Start()
    {
        object1.speed = 1;
        label.text = "IN";
    }


    public void ToggleState()
    {
        if (toggleStart == true)
        {
            object1.SetTrigger("idle");
            
            toggleStart = false;
        }



        if (toggleState == true)
        {
            object1.ResetTrigger("in");
            object1.SetTrigger("out");

            label.text = "OUT";
            toggleState = false;
        }
        else
        {
            object1.SetTrigger("in");
            object1.ResetTrigger("out");

            label.text = "IN";
            toggleState = true;
        }
    }
}
