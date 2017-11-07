using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour 
{

	public string Menu = string.Empty;
	
	public void OnMouseDown()
	{
		Application.LoadLevel("MainMenu");
	}
}
