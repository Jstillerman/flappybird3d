using UnityEngine;
using System.Collections;

public class pipeyscript : MonoBehaviour {
	public float speed = 5.0f;
	// Use this for initialization
	void Start () {

	
		transform.Translate(0, Random.Range (-4f, 3.8f), 0);
	


	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, -speed*Time.deltaTime);

		if (rigidbody.position.z < -23) {
			Destroy(this.gameObject);
			//GameObject.Find("CardboardMain").GetComponent<flappyScript>().score ++;
			flappyScript.score++;
				}

	
	}


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name != "Plane")
		{
			//CODE FOR DEATH

		
			flappyScript.score = 0;
			Application.LoadLevel(0);
			}

		}


	}

