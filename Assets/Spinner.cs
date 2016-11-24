using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float rot;
        rot = Time.time * 200;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -rot)); 
	}
}
