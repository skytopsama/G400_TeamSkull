using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	bool isPicked = false;
	int gridSize;
	GameManager gm;
	Camera cam;

	// Use this for initialization
	void Start () {
		gridSize  = GameObject.Find("BuildManager").GetComponent<GameManager>().gridSize;
		Debug.Log (gridSize);

		cam = GameObject.Find("Main Camera").GetComponent<Camera> ();
		
	}
	
	// Update is called once per frame
	void Update(){
		//Debug.Log (Camera.main.ScreenToWorldPoint (Input.mousePosition));

//		if(Input.GetMouseButtonUp(0)){
//			isPicked = false;
//		}

		if(isPicked == true){
			Debug.Log ("picked");

			Ray ray = cam.ScreenPointToRay (new Vector3 (transform.position.x, 0, transform.position.z));
			Debug.DrawRay (ray.origin, ray.direction *10, Color.red);
//			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//			transform.position = mousePos;
//
//			Vector3 currentPos = transform.position;
//			gameObject.transform.position = new Vector3(
//				Mathf.Round(currentPos.x), 
//				2, 
//				Mathf.Round(currentPos.z));
//			
			// if you want to smooth movement then lerp it

		}

	}

	void OnMouseDown(){
		isPicked = true;
	}
}
