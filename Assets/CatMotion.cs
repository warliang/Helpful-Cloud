using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMotion : MonoBehaviour {
    public Vector3 speed;
    public Quaternion rotation;
    public Transform transformer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transformer.SetPositionAndRotation(transformer.position - speed, rotation);
    }
}
