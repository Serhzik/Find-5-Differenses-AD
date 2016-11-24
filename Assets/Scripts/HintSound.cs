using UnityEngine;
using System.Collections;

public class HintSound : MonoBehaviour {
    public GameInterface GI;
    public ClickController Done, Fail;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Play()
    {
        if (GI.t <= 0 || GI.t == 30)
        {
            Done.Click();
            //Debug.Log("fail");
        }
        else
        {
            Fail.Click();
            //Debug.Log("fail");
        }
    }
        
}
