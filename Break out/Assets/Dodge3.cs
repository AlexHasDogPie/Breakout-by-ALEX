using UnityEngine;
using System.Collections;

public class Dodge3 : MonoBehaviour {
	public Vector3 movementDirection;
	
	void Start()
	{
		movementDirection = Vector3.left;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//float obMoveHorizontal = 5F;
		//Vector3 obMovement = new Vector3 (obMoveHorizontal, 0.0f, 0.0f);
		//transform.Rotate (new Vector3 (15,30,45) * Time.deltaTime);  
		//Vector3 movementDirection = Vector3.left;
		
		if (transform.position.x < -1)
			movementDirection = Vector3.right;
		
		else if (transform.position.x > 1)
			movementDirection = Vector3.left;
		
		transform.Translate (movementDirection * Time.deltaTime * 10);
	}
	
}
