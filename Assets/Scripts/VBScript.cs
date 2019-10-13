using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Model, Video, Description;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        Model.SetActive(true);

        Video.SetActive(false);

        Description.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    int count = 0;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "Button")
        {
            int var = count % 3;

            if (var == 0)
            {
                Model.SetActive(false);

                Description.SetActive(true);

                Video.SetActive(false);


            }

            if (var == 1)
            {
                Model.SetActive(false);

                Description.SetActive(false);

                Video.SetActive(true);



            }

            if (var == 2)
            {
                Model.SetActive(true);

                Description.SetActive(false);

                Video.SetActive(false);



            }


            count++;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
    }
}
