﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDescriptions : MonoBehaviour {

    //Needs to be set within the inspecter. 
    public GameObject LevelDescription;

    public List<GameObject> levelbbios = new List<GameObject>();

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ThisDescription()
    {
        levelbbios.AddRange(GameObject.FindGameObjectsWithTag("LevelBios"));
        foreach (GameObject levelbio in levelbbios)
        {

            levelbio.SetActive(false);
        }
        LevelDescription.SetActive(true);
    }
}
