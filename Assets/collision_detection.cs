using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detection : MonoBehaviour {


    private void Start()
    {
        particles.gameObject.SetActive(false);
    }

    public ParticleSystem particles;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION!!!!!!!!!!!!!!!!");
        particles.gameObject.SetActive(true);
    }

    public void OnCollisionStay(Collision collision)    
    {
        Debug.Log("hello!");
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("hello!");
        particles.gameObject.SetActive(true);
    }
}
