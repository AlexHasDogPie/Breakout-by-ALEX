using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {
	
	void OnTriggerEnter (Collider col)
	{
		GM.instance.LoseLife();
	}
}