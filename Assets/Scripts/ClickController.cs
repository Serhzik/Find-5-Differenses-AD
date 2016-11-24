using UnityEngine;
using System.Collections;

public class ClickController : MonoBehaviour {
    public AudioSource click;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Click()
    {
        click.Play();
    }
}
