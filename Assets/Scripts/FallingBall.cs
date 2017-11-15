using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour {

	public float maxVelocity;
	public Transform startPoint;

    private List<GameObject> collectedTrinkets = new List<GameObject>();
    private float teleportCooldown;
	private Vector3 velocityVector;
	private Rigidbody _rb;

	void Start () {
		
		_rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		/*
		if (_rb.velocity.y < -maxVelocity)
		{
			velocityVector = new Vector3(0, -maxVelocity, 0);
			_rb.velocity = velocityVector;
		}
		*/
		if (transform.position.y < -10)
		{
            Reset(); 	
		}
        if (teleportCooldown > 0)
        {
            teleportCooldown -= Time.deltaTime;
        }
		transform.position = new Vector3(transform.position.x, transform.position.y, 0);
		_rb.velocity = new Vector3(_rb.velocity.x, _rb.velocity.y, 0);
	}

    private void Reset()
    {
        transform.position = startPoint.position;
        _rb.velocity = Vector3.zero;
        foreach (GameObject trinket in collectedTrinkets)
        {
            trinket.SetActive(true);
        }
        collectedTrinkets.Clear();
    }
    private void OnTriggerEnter(Collider other)
	{

        if (other.tag == "GoalBox")
        {
            other.gameObject.GetComponent<GoalBox>().GoalEffects();
            Reset();
        }

        if (other.tag == "Teleport")
        {
            if (teleportCooldown <= 0)
            {
                transform.position = other.gameObject.GetComponent<Teleport>().pair.position;
                teleportCooldown = 1;
            }
        }

        if (other.tag == "Trinket")
        {
            collectedTrinkets.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
 	}
}
