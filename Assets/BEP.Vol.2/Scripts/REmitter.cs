using UnityEngine;
using System.Collections;

public class REmitter : MonoBehaviour 
{
	
	ParticleSystem pS;
	public int minSec = 1;
	public int maxSec = 12;
	bool isReady = false;
	

	void Start () 
	{
		pS = GetComponent <ParticleSystem>() as ParticleSystem;
		StartCoroutine (Timer ());
		InvokeRepeating("Holder", 0f, 1.5f);
	}
	
	IEnumerator Timer ()
	{
		isReady = false;
		
		pS.Play(true);
		yield return new WaitForSeconds (Random.Range (minSec, maxSec));
		pS.Stop(true);
		yield return new WaitForSeconds (Random.Range (minSec, maxSec));
		
		isReady = true;
	}
	
	void Holder ()
	{
		if (isReady)
		{
			StartCoroutine (Timer ());
		}
	}
}
