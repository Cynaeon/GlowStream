using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpot : MonoBehaviour {

    public GameObject bouncePad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);
        Instantiate(bouncePad, pos, Quaternion.identity);
    }

}
