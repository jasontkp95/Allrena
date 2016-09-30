using UnityEngine;
using System.Collections;

public class Player1Shoot : MonoBehaviour {

    public Rigidbody2D bulletPrefab01;
	public Rigidbody2D bulletPrefab02;
	public Rigidbody2D bulletPrefab03;
	private Player player;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above

	void Start ()
	{
		player = GameObject.Find ("Player01").GetComponent<Player> ();
	}

    // Update is called once per frame
    void Update ()
    {
			//shoot function
		if (Time.time >= coolDown) 
		{
			if (Input.GetKey (KeyCode.V)) 
			{
				if (player.WeaponAmmo > 0) 
				{
					if (player.WeaponType == 1) 
					{
					//fire
						Rigidbody2D bPrefab = Instantiate (bulletPrefab02, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody2D;

						bPrefab.AddForce (transform.localPosition * bulletSpeed);

						coolDown = Time.time + attackSpeed;

						player.WeaponAmmo--;
					}
					if (player.WeaponType == 2)
					{
						//water

						Rigidbody2D bPrefab = Instantiate (bulletPrefab03, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody2D;

						bPrefab.AddForce (transform.localPosition * bulletSpeed);

						coolDown = Time.time + attackSpeed;

						player.WeaponAmmo--;
					}
					if (player.WeaponType == 3) 
					{
						//earth

						Rigidbody2D bPrefab = Instantiate (bulletPrefab01, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody2D;

						bPrefab.AddForce (transform.localPosition * bulletSpeed);

						coolDown = Time.time + attackSpeed;

						player.WeaponAmmo--;
					}
				}
			}
		}
    }
}
