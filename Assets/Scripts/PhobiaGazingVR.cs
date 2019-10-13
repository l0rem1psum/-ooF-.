using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhobiaGazingVR : MonoBehaviour
{
    public Image imgGaze;
    
    
   

    public float totalTime = 2.0f;
    bool gvrStatus;
    float gvrTimer;

    public int distanceofRay = 60;
    private RaycastHit _hit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceofRay))
        {
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Enemy"))
            {
                Debug.Log("MOve!!");
                _hit.transform.gameObject.GetComponent<Move>().MoveForward();
                GVROff();

            }
            

        }

        
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
