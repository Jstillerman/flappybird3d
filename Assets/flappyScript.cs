using UnityEngine;
using System.Collections;

public class flappyScript : MonoBehaviour {
	public float jumpPower = 5f; 
	public float forwardVelocity = 5f;
	Vector3 temp;
	public static int score = 0;
	public static int highscore = 0;
	public AudioClip jump;

	void SpawnPipe() {
		Instantiate(Resources.Load("pipe")); 


		}

	// Use this for initialization
	void Start () {

		InvokeRepeating("SpawnPipe", 0, 2.6F);
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Input.acceleration.x);

		if (score > highscore) {highscore=score;}

		if (Input.GetMouseButtonDown (0) || Cardboard.SDK.CardboardTriggered) {
			//rigidbody.AddForce(new Vector3(0, jumpPower, 0));
			temp = new Vector3();
			temp.y = jumpPower;
			temp.x = Input.acceleration.x*100;

			rigidbody.velocity = temp;
			audio.PlayOneShot(jump, 1f);

				}

	
	}

	void OnGUI () {
		// Make a background box
		GUI.Label(new Rect(60, 60, 100, 20), "Score: "+score.ToString());
		GUI.Label(new Rect(60, 70, 100, 30), "High Score: "+highscore.ToString());

	}


}
