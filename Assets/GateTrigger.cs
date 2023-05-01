using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    public GameObject rock;
    public PathCreation.Examples.PathFollower cart;
    public float newSpeed;
    public float rate;
    //public Impact sc;
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
	rock.GetComponent<Impact> ().releaseRock();
	//sc.releaseRock();
	cart.targetSpeed = newSpeed;
	cart.rate = rate;
    }
}
