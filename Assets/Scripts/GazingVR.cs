using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazingVR : MonoBehaviour
{
    public Image imgGaze;
    public GameObject bubble,bubble_02,bubble_03, bubble_04, bubble_05;
    public int count = 0;
    public GameObject text;

    public float totalTime = 0.5f;
    bool gvrStatus;
    float gvrTimer;

    public int distanceofRay = 40;
    private RaycastHit _hit;


    // Start is called before the first frame update
     void Start()
    {
        //StartCoroutine(EnemyDroper());
       /* while (enemyCount < 10)
        {
            xpos = Random.Range(-2.0f, 2.0f);
            ypos = Random.Range(-1.0f, 1.0f);
            zpos = Random.Range(3.0f, 5.0f);
            Instantiate(enemyyy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            enemyCount += 1;
        }*/
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
                Debug.Log("Destroy");
                bubble.SetActive(false);
                count++;
                //_hit.transform.gameObject.GetComponent<Destroy>().DestroyEnemy();
                GVROff();
                
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Enemy_02"))
            {
                Debug.Log("Destroy");
                bubble_02.SetActive(false);
                count++;
                //_hit.transform.gameObject.GetComponent<Destroy>().DestroyEnemy();
                GVROff();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Enemy_03"))
            {
                Debug.Log("Destroy");
                bubble_03.SetActive(false);
                count++;
                //_hit.transform.gameObject.GetComponent<Destroy>().DestroyEnemy();
                GVROff();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Enemy_04"))
            {
                Debug.Log("Destroy");
                bubble_04.SetActive(false);
                count++;
                //_hit.transform.gameObject.GetComponent<Destroy>().DestroyEnemy();
                GVROff();

            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Enemy_05"))
            {
                Debug.Log("Destroy");
                bubble_05.SetActive(false);
                count++;
                //_hit.transform.gameObject.GetComponent<Destroy>().DestroyEnemy();
                GVROff();

            }

        }

        if(count==5)
        {
            text.SetActive(true);
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

    

   /* private IEnumerator EnemyDroper()
    {
        while (enemyCount < 10)
        {
            xpos = Random.Range(-2.0f, 2.0f);
            ypos = Random.Range(-1.0f, 1.0f);
            zpos = Random.Range(3.0f, 5.0f);
            Instantiate(enemyyy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }*/
}