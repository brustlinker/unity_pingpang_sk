using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {

		rigidbody2D=GetComponent<Rigidbody2D>();

		//前闭后开区间，也就是说只会产生0，1
		int number =Random.Range(0,2);

		if(number == 1)
		{
			rigidbody2D.AddForce( new Vector2(100,0) );
		}
		else
		{
			rigidbody2D.AddForce( new Vector2(-100,0) );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D( Collision2D coll)
	{
		if(coll.gameObject.tag == "Player")
		{
			Vector2 velocity = rigidbody2D.velocity;
			velocity.y += velocity.y/2+ coll.gameObject.GetComponent<Rigidbody2D>().velocity.y/2;
			rigidbody2D.velocity=velocity;

		}	
	}
}
