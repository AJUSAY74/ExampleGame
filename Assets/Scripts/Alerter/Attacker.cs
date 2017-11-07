using UnityEngine;
using System.Collections;


public class Attacker : MonoBehaviour
{
	public DragonCrunch dragon = null;

	public float speed = 5.0f;
	public Transform target = null;
	private bool chasing = false;


	private void Start()
	{
		dragon.alertingSound += Alert;

	}

	public void Alert(Transform source, AudioSource soundSource)
	{
		if (Vector3.Distance(transform.position, source.transform.forward) <
			soundSource.maxDistance)
		{
			StartCoroutine(WaitAlert());
			target = source;

		}
	}

	private IEnumerator WaitAlert()
	{
		yield return new WaitForSeconds(Random.Range(0.15f, 1.0f));

		GetComponent<AudioSource>().Play();
		chasing = true;
	}

	private void Update()
	{
		if (target == null || !chasing)
			return;

		transform.LookAt(target);

		transform.position+= (target.position - transform.position).normalized *
			Time.deltaTime * speed;

	}
	
}