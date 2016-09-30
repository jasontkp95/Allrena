using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	/* WeaponType integer
	 * 		0 = Fire
	 * 		1 = Water
	 * 		2 = Earth
	*/		
	public int WeaponType;
	public int WeaponAmmo;

	//Health
	public int curHealth;
	public int maxHealth = 5;

	// Use this for initialization
	void Start () {
		WeaponType = 0;
		curHealth = maxHealth;
	}

	// Update is called once per frame
	void Update () {
		if (WeaponAmmo == 0) {
			WeaponType = 0;
		}
		if (curHealth > maxHealth) {
			curHealth = maxHealth;
		}
		if (curHealth <= 0) {
			die ();
		}
	}

	void die() {
		Application.LoadLevel (Application.loadedLevel);
	}
}
