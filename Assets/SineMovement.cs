using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : MonoBehaviour {

    public Transform transformer;
    private Vector3 pos;
    float frequency = 2f;
    float magnitude = 0.3f;

	// Use this for initialization
	void Start () {
        pos = transformer.position;
	}
	
	// Update is called once per frame
	void Update () {
        transformer.position = pos + transformer.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
