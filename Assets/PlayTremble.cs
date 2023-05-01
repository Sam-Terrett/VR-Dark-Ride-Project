using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTremble : MonoBehaviour
{
    public AudioSource soundd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
	Debug.Log("Hello: ");
	soundd.Play();
    }
}
