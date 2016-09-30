using UnityEngine;
using System.Collections;

public class Player2Direction : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.localPosition = new Vector3 (0f, 0.55f, 0f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.localPosition = new Vector3 (0f, -0.55f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.localPosition = new Vector3 (0.55f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.localPosition = new Vector3 (-0.55f, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)&&Input.GetKey (KeyCode.UpArrow))
		{
			transform.localPosition = new Vector3 (0.55f, 0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)&&Input.GetKey (KeyCode.DownArrow))
		{
			transform.localPosition = new Vector3 (0.55f, -0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)&&Input.GetKey (KeyCode.UpArrow))
		{
			transform.localPosition = new Vector3 (-0.55f, 0.4f, 0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)&&Input.GetKey (KeyCode.DownArrow))
		{
			transform.localPosition = new Vector3 (-0.55f, -0.4f, 0f);
		}

	}
}
