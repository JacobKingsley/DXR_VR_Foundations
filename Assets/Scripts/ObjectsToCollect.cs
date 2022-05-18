using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
	public static int skulls=0;
    // Start is called before the first frame update
    void Awake(){
    	skulls++;
    }

    void OnTriggerEnter(Collider player) 
    {
    	if (player.gameObject.tag == "Player")
    	{
    		skulls--;
    	}
    	gameObject.SetActive(false);
    }
}
