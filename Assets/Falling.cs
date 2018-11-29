using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour {
    public Vector3 speed;
    public Transform transformer;
    public Quaternion rotation;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transformer.SetPositionAndRotation(transformer.position - speed, rotation);
    }
}
