using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {

	//! Check Collision
	/* Item element
	 * 		0 = Fire
	 * 		1 = Water
	 * 		2 = Earth
	*/		

	private int Element;

	void Start () {
		if (gameObject.name == "Item_Fire") {Element = 0;}
		if (gameObject.name == "Item_Water") {Element = 1;}
		if (gameObject.name == "Item_Earth") {Element = 2;}
		if (gameObject.name == "Item_Fire (1)") {Element = 0;}
		if (gameObject.name == "Item_Water (1)") {Element = 1;}
		if (gameObject.name == "Item_Earth (1)") {Element = 2;}
		if (gameObject.name == "Item_Fire (2)") {Element = 0;}
		if (gameObject.name == "Item_Water (2)") {Element = 1;}
		if (gameObject.name == "Item_Earth (2)") {Element = 2;}
	}


	void Update () {
		
		//! Check if this item is a slot machine
		//! if so, randomize items

		if (gameObject.name == "ItemSlotMachine") {
			Element++;
			if (Element > 2) {Element = 0;}
		}
	}


	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Player") 
		{
			collider.GetComponent<Player> ().WeaponAmmo = 3;
			if (Element == 0) 
			{
				collider.GetComponent<Player> ().WeaponType = 1;
			}
			if (Element == 1) 
			{
				collider.GetComponent<Player> ().WeaponType = 2;
			}
			if (Element == 2) 
			{
				collider.GetComponent<Player> ().WeaponType = 3;
			}

			Destroy (gameObject);
		}


	}
}