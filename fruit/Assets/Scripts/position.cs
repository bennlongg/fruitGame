using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	    void OnDrawGizmos()
    {
		Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}
