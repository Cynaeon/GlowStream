using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBox : MonoBehaviour {

    public GameObject goalEffect;


	void Start () {

	}
	
	void Update () {
        
	}

    internal void GoalEffects()
    {
        Instantiate(goalEffect, transform.position, Quaternion.identity);

    }
}
