using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {


    public ParticleSystem particles;

	// Use this for initialization
	void Start () {
		
	}

    public void ResetParticles()
    {
        particles.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
