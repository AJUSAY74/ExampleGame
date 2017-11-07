using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{
	public string TheCrago = string.Empty;
	
	public void OnMouseDown()
	{
		Application.LoadLevel("OUTPOST");
	}

}
