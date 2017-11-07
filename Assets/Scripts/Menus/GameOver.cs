using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{

	public string GameFinish = string.Empty;
	
	private void OnCollisionEnter(Collision c)
	{
		if (c.collider.tag == "Player")
		{
			Application.LoadLevel("Victory");
		}
	}
}
