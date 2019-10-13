using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRSettings.enabled = false;
    }

    public void GotoMed()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(1);
    }
    

    public void GotoPB()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(2);
    }

    public void GotoPhobia()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(3);
    }

    public void GotoBubblePop()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(4);
    }

    public void GotoAudience()
    {
        XRSettings.enabled = true;
        SceneManager.LoadScene(5);
    }

    public void GotoTherapy()
    {

        SceneManager.LoadScene(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
