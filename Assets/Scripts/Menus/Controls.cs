using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
	public string Menu = string.Empty;
	
	public void OnMouseDown()
	{
		Application.LoadLevel("Controls");
	}
}