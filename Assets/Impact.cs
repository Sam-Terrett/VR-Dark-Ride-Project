using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

//TAKEN FROM https://www.youtube.com/watch?v=yE0JdtVTnVk&ab_channel=MMuradIqbal-TechNuggets-Javangelist
public class Impact : MonoBehaviour
{
     public Rigidbody rb;
     public GameObject visualImp;
     public AudioSource tickSource;
     //public CameraShake shake;
     public ScreenShakeVR shake;


     void Start ()   
     {
	tickSource = GetComponent<AudioSource> ();
	rb = GetComponent<Rigidbody>();
     }

     void Update () {

     }        

     public void releaseRock ()
     {
	rb.isKinematic = false;
     }
 
     void OnCollisionEnter (Collision collision)  //Plays Sound Whenever collision detected
     {
	ContactPoint contact = collision.contacts[0];
	tickSource.Play ();
        RockImpactDust sc = visualImp.GetComponent<RockImpactDust> ();
	sc.Imp(contact.point);

	//shake.shakeDuration = 0.5f;
	shake.Shake(0.5f, 0.8f);

	//https://gist.github.com/corycorvus/2b0788719f06fc162a8d5466ba58ac4d
        Debug.Log("Haptic Unity");

        


        //InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        //HapticCapabilities capabilities;
        //if (device.TryGetHapticCapabilities(out capabilities))
            //if (capabilities.supportsImpulse)
                //device.SendHapticImpulse(0, 0.5f, 1.0f);

        //InputDevice device1 = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        //if (device1.TryGetHapticCapabilities(out capabilities))
            //if (capabilities.supportsImpulse)
                //device1.SendHapticImpulse(0, 0.5f, 1.0f);

     }

}