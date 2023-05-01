using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCont : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
	anim.SetFloat("offse", Random.Range(0.0f,1.0f));
    }
}
