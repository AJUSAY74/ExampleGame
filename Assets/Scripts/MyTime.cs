using UnityEngine;
using System.Collections;

public class MyTime : MonoBehaviour 
{
	float time = 1.0f;
	float seconds = 10.0f;
	float minutes = 0.0f;

	void Update()
	{
		time -= Time.deltaTime;
		//time = ((int)time / 1);

        if (time <= 0)
        {
            seconds--;
            time = 1.0f;
        }

        if (seconds <= 0)
        {
            minutes--;
            seconds += 59;
        }

		if(minutes <= 0 && seconds <= 1)
			Application.LoadLevel("MainMenu");

	}
	

	public void OnGUI()
	{
		GUILayout.Label("");
		GUILayout.Label ("<b><size=20><color=blue>Time:</color></size></b> " + minutes + ":"  + seconds + ":" + (int)(time * 1000)  );
	}

}
