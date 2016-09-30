using UnityEngine;
using System.Collections;

public class Player1Element : MonoBehaviour {
	private bool fireElement = false;
	private bool waterElement = false;
	private bool earthElement = false;
	private bool noElement = false;
	public GameObject fireBullet;
	public GameObject waterBullet;
	public GameObject earthBullet;
	Collision2D coll;
	private Player player;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find("Player01").GetComponent<Player>();
		noElement = true;
		if (noElement == true) 
		{
			Debug.Log ("noelement");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (player.WeaponType == 2) 
		{
			fireElement = true;
			waterElement = false;
			earthElement = false;
			noElement = false;

			if (fireElement == true) 
			{
				Debug.Log ("fire");
			}
		}

		if (player.WeaponType == 3) 
		{
			fireElement = false;
			waterElement = true;
			earthElement = false;
			noElement = false;

			if (waterElement == true) 
			{
				Debug.Log ("water");
			}
		}

		if (player.WeaponType == 1) 
		{
			fireElement = false;
			waterElement = false;
			earthElement = true;
			noElement = false;

			if (earthElement == true) 
			{
				Debug.Log ("earth");
			}
		}

		if (player.WeaponType == 0) 
		{
			fireElement = false;
			waterElement = false;
			earthElement = false;
			noElement = true;

			if (noElement == true) 
			{
				Debug.Log ("noelement");
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (fireElement == true) 
		{
			if (coll.gameObject.tag == "BulletFire") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletWater") 
			{
				Debug.Log ("0.5 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletEarth") 
			{
				Debug.Log ("2 damage");
				player.curHealth = player.curHealth - 2;
			}
		}

		if (waterElement == true) 
		{
			if (coll.gameObject.tag == "BulletFire") 
			{
				Debug.Log ("2 damage");
				player.curHealth = player.curHealth - 2;
			}

			if (coll.gameObject.tag == "BulletWater") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletEarth") 
			{
				Debug.Log ("0.5 damage");
				player.curHealth--;
			}
		}

		if (earthElement == true) 
		{
			if (coll.gameObject.tag == "BulletFire") 
			{
				Debug.Log ("0.5 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletWater") 
			{
				Debug.Log ("2 damage");
				player.curHealth = player.curHealth - 2;
			}

			if (coll.gameObject.tag == "BulletEarth") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}
		}

		if (noElement == true) 
		{
			if (coll.gameObject.tag == "BulletFire") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletWater") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}

			if (coll.gameObject.tag == "BulletEarth") 
			{
				Debug.Log ("1 damage");
				player.curHealth--;
			}
		}
	}
}
