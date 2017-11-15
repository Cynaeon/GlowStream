using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildObjects : MonoBehaviour {

	public enum BuildObject
	{
		None = 0,
		Bounce = 1,
		Sticky = 2
	}

	public GameObject[] buildObjects;
	public int selected;
    public GameObject selectedObject;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetButtonDown("Tab"))
		{
			selected++;
			if (selected > buildObjects.Length - 1)
				selected = 0;
		}

        selectedObject = buildObjects[selected];
	}
}
