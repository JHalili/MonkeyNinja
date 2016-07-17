using UnityEngine;
using System.Collections;
using System;

public class Finger : MonoBehaviour {
    private SpriteRenderer sp;
    private bool touchDown;

    public bool TouchDown {
        get {
            return touchDown;
        }
    }
    // Use this for initialization
    void Start () {
        sp = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; i++) 
            touchDown = sp.bounds.Contains(Input.GetTouch(i).position);
    }
}
