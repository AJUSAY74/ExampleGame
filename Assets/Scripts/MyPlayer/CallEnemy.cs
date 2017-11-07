using UnityEngine;
using System.Collections;

public class CallEnemy : MonoBehaviour 
{
	public string GameFinish = string.Empty;

	private void OnCollisionEnter(Collision c)
	{		
		if(c.collider.tag == "AlertZone1")
		{
			Destroy(c.collider);            
		}

		if(c.collider.tag == "AlertZone2")
		{
			Destroy(c.collider);            
		}

		
		if (c.collider.tag == "Objective")
		{
			Destroy(c.collider);
			//Debug.Log( "Hit" );
			Application.LoadLevel("GameFinish");
		}

	}
	
}
