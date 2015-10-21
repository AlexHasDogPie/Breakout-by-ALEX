using UnityEngine;
using System.Collections;

public class Dodge : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (0.0f,0.0f,45) * Time.deltaTime*2);  
	}
	
}
