using UnityEngine;
using System.Collections;

public class AwingController : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150f;
		float y = Input.GetAxis ("Vertical") * Time.deltaTime * 150f;
		gameObject.GetComponent<Rigidbody>().AddForce (x, y, 0);
	}
}
