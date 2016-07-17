using System;
using System.Collections;
using UnityEngine;
public class Lane : MonoBehaviour {
    public GameObject FingerBox;
    public GameObject spamPoint;
    // Random weapon generator

    // Use this for initialization
    void Start() {
    }
    
    // Update is called once per frame
    void Update() {
    }

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        Console.WriteLine("game object destroyed");
    }
}
