using UnityEngine;
using System.Collections;

public class DragonCrunch : MonoBehaviour
{
	public delegate void AlertingSoundEvent(Transform sender, AudioSource soundSource);
	public event AlertingSoundEvent alertingSound = null;

	private void OnCollisionEnter(Collision c)
	{
		if (c.collider.gameObject.tag == "AlertZone1")
		{
			GetComponent<AudioSource>().Play();

			if (alertingSound != null)
				alertingSound(transform, GetComponent<AudioSource>());

			Debug.Log( "YOU Hit It" );
			
		}
	}
}