using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
    float speed;

	// Use this for initialization
	void Start ()
    {
        speed = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //get the bullet's current position
        Vector2 position = transform.position;

        //compute the bullet's new position
        position = new Vector2(position.x, position.y + speed + Time.deltaTime);

        //update the bullet's position
        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //if the bullet went outside, kill it.
        if(transform.position.y > max.y || transform.position.y < max.y)
        {
            Destroy(gameObject);
        }
	}
}
