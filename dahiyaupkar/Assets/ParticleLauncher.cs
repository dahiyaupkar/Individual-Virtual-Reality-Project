using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour {

    public ParticleSystem particleLauncher;
    public ParticleSystem splatterParticles;

    void Start ()
    {

    }

    void OnParticleCollision(GameObject other)
    {

            EmitAtLocation ();
        }

    void EmitAtLocation()
    {
        splatterParticles.Emit (10);
    }

    void Update ()
    {
        if (Input.GetButton ("Fire1"))
        {
            particleLauncher.Emit(10);
        }

    }
}
