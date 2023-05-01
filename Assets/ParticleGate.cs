using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGate : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem parti;
    public PathCreation.Examples.PathFollower cart;
    public float newSpeed;
    public float rate;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
	Debug.Log("a");
	parti.Play();
	cart.targetSpeed = newSpeed;
	cart.rate = rate;
    }
}
