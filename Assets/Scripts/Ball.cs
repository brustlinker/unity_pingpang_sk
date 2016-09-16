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
		Vector2 velocity=rigidbody2D.velocity;

		//防止player移动速度过慢导致ball移动速度过慢
		if(velocity.x<9&&velocity.x>-9)
		{
			if(velocity.x>0)
			{
				velocity.x=10;
			}
			else
			{
				velocity.x=-10;
			}
			rigidbody2D.velocity = velocity;
		}

		//防止player移动速度过快导致ball移动速度过快
		if(velocity.y>10||velocity.y<-10)
		{
			if(velocity.y>0)
			{
				velocity.y=10;
			}
			else
			{
				velocity.y=-10;
			}
			rigidbody2D.velocity = velocity;
		}
	}

	void OnCollisionEnter2D( Collision2D coll)
	{
		if(coll.gameObject.tag == "Player")
		{
			Vector2 velocity = rigidbody2D.velocity;
			velocity.y += velocity.y/2+ coll.gameObject.GetComponent<Rigidbody2D>().velocity.y/2;
			rigidbody2D.velocity=velocity;

		}	
		Debug.Log(rigidbody2D.velocity);
	}
}
