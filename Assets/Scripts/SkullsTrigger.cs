using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullsTrigger : MonoBehaviour
{

    public Animator skullAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && ObjectsToCollect.skulls==0)
        {
            skullAnim.SetBool("open",true);
        }
    }

}
