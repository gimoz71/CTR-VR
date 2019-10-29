using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioControl : MonoBehaviour
{

    public AudioSource rumore;
    public Text label;

    private bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        label.text = "Avvia RMN";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioSwitch()
    {
        if (on == false)
        {
            //Debug.Log("AVVIATO");
            rumore.Play();
            label.text = "STOP";
            on = true;
        } else
        {
            //Debug.Log("SPENTO");
            rumore.Stop();
            label.text = "START";
            on = false;
        }
    }
}
