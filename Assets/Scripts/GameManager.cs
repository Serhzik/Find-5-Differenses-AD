﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public int FindedDifs;
    public float time;
    public static GameManager Instance;
    public bool[] Dif;
    public bool winner, paused;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (!paused)
            time += Time.deltaTime;

	}
    public void Find(int dif)
    {
        FindedDifs++;
        Dif[dif] = true;
        if (FindedDifs == 5) // Win
        {
            winner = true;
            int stars = 1;
            if (time < MenuManager.Instance.twoStarSecs)
                stars++;
            if (time < MenuManager.Instance.threeStarSecs)
                stars++;
            MenuManager.Instance.OpenLvl(stars);
            
        }
    }
}
