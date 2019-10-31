using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string scene;
    public string buttonLabel;
    public Text button;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeLevel()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
