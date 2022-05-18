using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenAngle : MonoBehaviour
{
	public float gold = 137.5f;
	public GameObject part;
	public float scaleMin = 1.0f, scaleMax = 1.1f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 _curPosition = new Vector3();

        GameObject newObj;
        for (int i = 0; i < 100; i++)
        {
        	float radius = Random.Range(scaleMin, scaleMax);
        	// newObj = GameObject.Instantiate(seedObj, _curPosition, Quaternion.identity) as GameObject;
        }
    }

}
