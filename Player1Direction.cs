using UnityEngine;
using System.Collections;

public class Player1Direction : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.localPosition = new Vector3 (0f, 0.55f, 0f);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.localPosition = new Vector3 (0f, -0.55f, 0f);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			transform.localPosition = new Vector3 (0.55f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			transform.localPosition = new Vector3 (-0.55f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.D)&&Input.GetKey (KeyCode.W))
		{
			transform.localPosition = new Vector3 (0.55f, 0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.D)&&Input.GetKey (KeyCode.S))
		{
			transform.localPosition = new Vector3 (0.55f, -0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.A)&&Input.GetKey (KeyCode.W))
		{
			transform.localPosition = new Vector3 (-0.55f, 0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.A)&&Input.GetKey (KeyCode.S))
		{
			transform.localPosition = new Vector3 (-0.55f, -0.4f, 0f);
		}
			
	}
}
