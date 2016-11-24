using UnityEngine;
using System.Collections;

public class WinController : MonoBehaviour {
    public bool win;
    public ClickController sound;
    public AudioSource music;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameManager.Instance.winner && !win)
        {
            win = true;
            sound.Click();
            music.Stop();
            Invoke("PlayMusic", 4);
        }
	}
    void PlayMusic()
    {
        music.Play();
    }
}
