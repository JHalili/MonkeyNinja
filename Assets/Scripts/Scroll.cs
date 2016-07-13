using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    public float speed;

    private MeshRenderer rend;
    private Vector2 offset;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        offset = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        offset.y = Time.time * speed;
        rend.material.mainTextureOffset = offset;
	}
}
