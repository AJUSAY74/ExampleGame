using UnityEngine;
using System.Collections;

public class HealthControl : MonoBehaviour 
{
	public string MainMenu = string.Empty;
	public int health = 10;

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Zombie1")
			health--;
		if (c.collider.tag == "Health")
			health+=1;

		
		if(health <= 1)
			Application.LoadLevel("GameOver");
	}
	
	
	public void OnGUI()
	{
			GUILayout.Label("");
			GUILayout.Label("");
			GUILayout.Label("<b><size=20><color=green>Health</color></size></b> " + health);
	}
}
