using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {
    public float speed;

    //rivate Rigidbody2D rb2d;

    //public Transform firePoint;
    //public GameObject bullet;

	private bool facingRight;
	private bool facingDown;

	private float xScale;
	private float yScale;

    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
    }

    //Player movement 
    void FixedUpdate()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);*/
    }

    void Update()
    {
		if (Input.GetKey (KeyCode.A)) 
		{
			this.transform.Translate (new Vector3 (-1f, 0f, 0f) * Time.deltaTime * speed);
			//transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			this.transform.Translate (new Vector3 (1f, 0f, 0f) * Time.deltaTime * speed);
			//transform.localScale = new Vector3 (1f, 1f, 1f);
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			this.transform.Translate (new Vector3 (0f, 1f, 0f) * Time.deltaTime * speed);
			//transform.localScale = new Vector3 (1f, 1f, 1f);

		}
		if (Input.GetKey (KeyCode.S)) 
		{
			this.transform.Translate (new Vector3 (0f, -1f, 0f) * Time.deltaTime * speed);
			//transform.localScale = new Vector3 (1f, -1f, 1f);
		}
		
        //Player rotating toward mouse cursor
        /*Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));*/
    }

}
