using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    private Rigidbody2D rigidBody;
    private Vector2 direction;
    public float speed;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        direction = new Vector2(0, 1);
        rigidBody.velocity = direction * speed;
	}
}
