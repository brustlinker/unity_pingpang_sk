using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	private BoxCollider2D rightWall;
	private BoxCollider2D leftWall;
	private BoxCollider2D upWall;
	private BoxCollider2D downWall;

	// Use this for initialization
	void Start () {
		ResetWall();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ResetWall()
	{
		rightWall = transform.Find("rightWall").GetComponent<BoxCollider2D>();
		leftWall  = transform.Find("leftWall").GetComponent<BoxCollider2D>();
		upWall    = transform.Find("upWall").GetComponent<BoxCollider2D>();
		downWall  = transform.Find("downWall").GetComponent<BoxCollider2D>();


		//Vector2 upWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2,Screen.height));
		//upWall.transform.position = upWallPosition+new Vector2(0,0.5f);
		//float width = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height)).x*2;
		//upWall.size = new Vector2(width,1);


		Vector3 tempPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));

		upWall.transform.position = new Vector3(0,tempPosition.y+0.5f,0);
		upWall.size = new Vector2(tempPosition.x*2,1);

		downWall.transform.position = new Vector3(0,-tempPosition.y-0.5f,0);
		downWall.size = new Vector2(tempPosition.x*2,1);

		rightWall.transform.position = new Vector3(tempPosition.x+0.5f,0,0);
		rightWall.size = new Vector2(1,tempPosition.y*2);

		leftWall.transform.position = new Vector3(-tempPosition.x-0.5f,0,0);
		leftWall.size = new Vector2(1,tempPosition.y*2);
	}
}
