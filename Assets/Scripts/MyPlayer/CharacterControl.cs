using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour
{
	public float speed = 5.0f;
	public float run = 20.0f;
	public float rotate = 10.0f;

		
	private void Start()
	{
		GetComponent<Animation>().Play("idle0");
	}
	 
	void Update()
	{

		if(Input.GetKey(KeyCode.W))
		{
			transform.position += transform.forward * Time.deltaTime * speed;
			GetComponent<Animation>().Play("walk");

			GetComponent<Animation>().CrossFade ("idle0");
		}

		if(Input.GetKey(KeyCode.S))
		{			
			transform.position -= transform.forward * Time.deltaTime * speed;
			GetComponent<Animation>().Play("walk");

			GetComponent<Animation>().CrossFade ("idle0");
		}
		if (Input.GetKey(KeyCode.E))
			transform.Rotate(Vector3.up * Time.deltaTime * rotate);
		
		if (Input.GetKey (KeyCode.Q))
			transform.Rotate (Vector3.down * Time.deltaTime * rotate);

		if(Input.GetKey(KeyCode.R))
		{			
			transform.position += transform.forward * Time.deltaTime * run;
			GetComponent<Animation>().Play("run");

			GetComponent<Animation>().CrossFade ("idle0");
		}
		if(Input.GetKey(KeyCode.F))
		{			
			GetComponent<Animation>().Play("stand_Fshot");

			GetComponent<Animation>().CrossFade ("idle0");
		}

	}



}

