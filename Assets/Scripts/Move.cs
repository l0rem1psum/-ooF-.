using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    

    public void MoveForward()
    {
        player.transform.Translate(0f, 0f, (3.0f));
        
    }
}
