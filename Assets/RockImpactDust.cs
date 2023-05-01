using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockImpactDust : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //rock = GetComponent<GameObject> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Imp(Vector3 position)
    {
	gameObject.GetComponent<ParticleSystem>().Play();
	gameObject.transform.position = position;
    }
}
