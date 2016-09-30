using UnityEngine;
using System.Collections;

public class destroyBullet : MonoBehaviour {
    public GameObject Bullet;
    public float Time;
	// Bullet dissappear after seconds
	void Update ()
    {
        Destroy(Bullet, Time);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") 
		{
			Destroy (Bullet);
		}
	}
}
