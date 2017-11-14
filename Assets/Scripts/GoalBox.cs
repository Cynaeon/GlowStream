using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBox : MonoBehaviour {

    public GameObject burst;
    public Transform fill;
    public float currentFill;
    public float drainRate;

    private float startPos;
    private float maxFill = 1.6f;
    private bool filled;

	void Start () {
        startPos = fill.localPosition.y;
	}
	
	void Update () {
        if (currentFill >= maxFill)
            filled = true;
        if (!filled)
        {
            if (currentFill > 0.01f)
                currentFill -= Time.deltaTime * drainRate;
            else
                currentFill = 0.01f;
        }
        fill.localScale = new Vector3(fill.localScale.x, currentFill, fill.localScale.z);
        fill.localPosition = new Vector3(fill.localPosition.x, startPos + currentFill / 2, fill.localPosition.z);
	}


    public void Fill()
    {
        if (currentFill < maxFill)
            currentFill += 0.01f;
    }
}
