using UnityEngine;
using System.Collections;

public class SpamPoint : MonoBehaviour {
    public GameObject Weapons;
    IEnumerator WeaponGenerator() {
        while (true) {
            // Console.log("bla bla bla");
            yield return new WaitForSeconds(1);
            if (Random.Range(0, 5) == 4)
                Instantiate(Weapons, transform.position, Quaternion.identity);
        }
    }
    // Use this for initialization
    void Start () {
        StartCoroutine(WeaponGenerator());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
