using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public KeyCode upKey;
	public KeyCode downKey;

	public float   speed = 10;


	private Rigidbody2D rigid2d;

	// Use this for initialization
	void Start () {
		rigid2d=this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(upKey))
		{
			rigid2d.velocity=new Vector2(0,speed);
		}
		else if(Input.GetKey(downKey))
		{
			rigid2d.velocity=new Vector2(0,-speed);
		}
		else
		{
			rigid2d.velocity=new Vector2(0,0);
		}
	}
}
