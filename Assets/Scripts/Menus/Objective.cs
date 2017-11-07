using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour 
{
	public string Menu = string.Empty;
	
	public void OnMouseDown()
	{
		Application.LoadLevel("Objective");
	}
}
