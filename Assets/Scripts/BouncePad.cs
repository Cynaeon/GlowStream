using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        
	}

    private void Rotate()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z -15);
    }

    private void OnMouseOver()
    {
        if ((Input.GetAxis("Mouse ScrollWheel")) > 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 15);
        }
        else if ((Input.GetAxis("Mouse ScrollWheel")) < 0)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 15);

        if (Input.GetButtonDown("RightClick"))
            Destroy(gameObject);
    }
}
