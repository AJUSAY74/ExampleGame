using UnityEngine;
using System.Collections;

public class ProjectileDestroyer : MonoBehaviour
{
	
	private void OnCollisionEnter(Collision c)
	{
		if(c.collider.tag == "Bullet")
		{
			Destroy(c.gameObject);
			
		}

		if(c.collider.tag == "ZombieFire")
		{
			Destroy(c.gameObject);
			
		}
	}
	

}