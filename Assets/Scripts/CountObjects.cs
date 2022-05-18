using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour
{
	public GameObject objToDestroy;
	public GameObject objUI;
    // Start is called before the first frame update
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }

    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<Text>().text = "Skulls Remaining: " + ObjectsToCollect.skulls.ToString();
        if (ObjectsToCollect.skulls == 0)
        {
        	Destroy(objToDestroy);
        	objUI.GetComponent<Text>().text = "All Skulls Collected, Proceed to Shrine";
        }
    }
}
