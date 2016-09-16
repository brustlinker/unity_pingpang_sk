using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public KeyCode upKey;
	public KeyCode downKey;

	public float   speed = 10;


	private Rigidbody2D rigid2d;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		rigid2d=this.GetComponent<Rigidbody2D>();
		audio = this.GetComponent<AudioSource>();
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

	void OnCollisionEnter2D()
	{
		audio.pitch = Random.Range(0.8f,1.0f);
		audio.Play();
	}
}
