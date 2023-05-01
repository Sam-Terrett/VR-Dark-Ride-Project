using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TestCollisionTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    public ScreenShakeVR shake;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
	Debug.Log("ye");
        // particles
        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        //List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

        // get
        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        //int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);

        // iterate
        for (int i = 0; i < numEnter; i++)
        {
            ParticleSystem.Particle p = enter[i];
            AudioSource.PlayClipAtPoint(clip, transform.TransformPoint(p.position), 0.7f);
	    shake.Shake(0.5f, 0.8f);
            
            //InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
            //HapticCapabilities capabilities;
            //if (device.TryGetHapticCapabilities(out capabilities))
                //if (capabilities.supportsImpulse)
                    //device.SendHapticImpulse(0, 0.5f, 1.0f);

            //device = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
            //if (device.TryGetHapticCapabilities(out capabilities))
                //if (capabilities.supportsImpulse)
                    //device.SendHapticImpulse(0, 0.5f, 1.0f);

        }
        //for (int i = 0; i < numExit; i++)
        //{
        //    ParticleSystem.Particle p = exit[i];
        //    p.startColor = new Color32(0, 255, 0, 255);
        //    exit[i] = p;
        //}

        // set
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        //ps.SetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    }

}
