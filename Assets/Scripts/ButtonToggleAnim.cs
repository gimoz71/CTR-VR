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

    public string labelOne;
    public string labelTwo;
    public string triggerZero;
    public string triggerOne;
    public string triggerTwo;


    // Use this for initialization
    void Start()
    {
        object1.speed = 1;
        label.text = labelOne;
    }


    public void ToggleState()
    {
        if (toggleStart == true)
        {
            object1.SetTrigger(triggerZero);
            
            toggleStart = false;
        }



        if (toggleState == true)
        {
            object1.ResetTrigger(triggerOne);
            object1.SetTrigger(triggerTwo);

            label.text = labelTwo;
            toggleState = false;
        }
        else
        {
            object1.SetTrigger(triggerOne);
            object1.ResetTrigger(triggerTwo);

            label.text = labelOne;
            toggleState = true;
        }
    }
}
