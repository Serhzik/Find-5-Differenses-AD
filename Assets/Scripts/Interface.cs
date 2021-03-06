﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Interface : MonoBehaviour {

    public GameObject[] Opened;
    public GameObject[] Stars1, Stars2, Stars3;

    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < MenuManager.Instance.LvlOpened; i++)
        {
            Opened[i].SetActive(true);
            
            {
                if (MenuManager.Instance.Stars[i] == 1)
                    Stars1[i].SetActive(true);
                else if (MenuManager.Instance.Stars[i] == 2)
                    Stars2[i].SetActive(true);
                else if (MenuManager.Instance.Stars[i] == 3)
                    Stars3[i].SetActive(true);
            }
        }
	}
    public void OpenRandomStar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }
    public void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
    public void loadLevel(int i)
    {
        //AdController.Instance.RequestInterstitial();
        MenuManager.Instance.loadedlevel = i;
        SceneManager.LoadScene("Game");
    }
}
