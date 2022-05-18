using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DawnReset : MonoBehaviour
{

	private Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("resetting animation1");
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Reset()
    {
        Debug.Log("resetting animation2");
        myAnim.SetBool("junk", false);
    }
}
