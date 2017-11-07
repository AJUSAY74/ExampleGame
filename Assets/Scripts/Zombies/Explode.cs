using UnityEngine;
using System.Collections;


public class Explode : MonoBehaviour
{
	public GameObject Zombie = null;

	private GameObject instantiatedObj;

	
	private void OnCollisionEnter(Collision c)
	{
		if (c.transform.GetComponent<Rigidbody>() != null)
			c.transform.GetComponent<Rigidbody>().AddExplosionForce(5, transform.position, 2, 2);

		if (c.collider.tag == "Zombie1")
			Destroy (c.gameObject);

	}
}