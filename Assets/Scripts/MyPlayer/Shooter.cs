using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{

	public GameObject bullet = null;
	public float shotForce = 10000.0f;
	private int rounds = 6;
	public float nextLoad = -2.0f;

	
	void Start () 
	{
		nextLoad = Time.time + 2.0f;
		
	}
	private void Update()
	{
	

		if (rounds > 0 && Input.GetKeyDown (KeyCode.F)) 
		{


			GameObject spawn = 
			Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			
			//spawn.rigidbody.AddForce (-transform.forward * shotForce);
			//audio.Play ();
			
					rounds--;			
		} 

		if(Time.time >= nextLoad)

		if (Input.GetKey (KeyCode.T)) 
		{
							
			nextLoad = nextLoad+5;
			rounds ++;

		}

	}
	

	private void OnGUI()
	{
		GUI.color = Color.red;
		GUILayout.Label ("<b><size=20>Rounds</size></b> " + rounds);


	}


}


	



