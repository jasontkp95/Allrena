using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Sprite[] HeartSprites;
	public Sprite[] HeartSprites2;

	public Image HeartUI;
	public Image HeartUI2;

	private Player player;
	private Player player2;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player01").GetComponent<Player>();
		player2 = GameObject.Find("Player02").GetComponent<Player>();

	}

	// Update is called once per frame
	void Update () {
		HeartUI.sprite = HeartSprites[player.curHealth];
		HeartUI2.sprite = HeartSprites2[player2.curHealth];
	}
}
