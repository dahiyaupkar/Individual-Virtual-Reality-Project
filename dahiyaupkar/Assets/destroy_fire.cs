using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("particle_launcher"))
        {
            if (Input.GetButton("Fire1"))
            {
                Destroy(this.gameObject);

            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
