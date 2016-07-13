using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    public float rotationSpeed;
    private Rigidbody2D rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.angularVelocity = rotationSpeed;
    }
	
	// Update is called once per frame
	void Update () {

	}
}
