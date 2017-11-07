using UnityEngine;
using System.Collections;

public class SlidingDoor1 : MonoBehaviour 
{

	void Start()
	{
		GetComponent<Animation>().Play ("SlidingDoor1Close");

	}
	
	private void OnTriggerEnter(Collider c) 
	{
		if (c.gameObject.tag == "Player")
            GetComponent<Animation>().Play ("SlidingDoor1Open");
	}

	private void OnTriggerExit(Collider c) 
	{
		if (c.gameObject.tag == "Player")
            GetComponent<Animation>().Play ("SlidingDoor1Close");
	}

}
