using UnityEngine;
using System.Collections;

public class FoundVehicle : MonoBehaviour 
{
	public string GameFinish = string.Empty;
	
	private void OnCollisionEnter(Collision c)
	{
		if (c.collider.tag == "Objective")
		{
			Destroy(c.collider);
			Debug.Log( "Hit" );
			Application.LoadLevel("GameFinish");
		}
	}
}
