using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
	public Animator bridgeAnim;
	public Animator dawnAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bridgeAnim.SetBool("open",true);
            dawnAnim.SetBool("dawnYes", true);
        }
    }


}
