using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	bool isPicked = false;
	int gridSize;
	GameManager gm;

	// Use this for initialization
	void Start () {
		gridSize  = GameObject.Find("Game Manager").GetComponent<GameManager>().gridSize;
		
	}
	
	// Update is called once per frame
	void Update(){

		if(Input.GetMouseButtonUp(0)){
			isPicked = false;
		}

		if(isPicked == true){
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = mousePos;

			Vector3 currentPos = transform.position;
			gameObject.transform.position = new Vector3(
				Mathf.Round(currentPos.x), 
				Mathf.Round(currentPos.y), 
				Mathf.Round(currentPos.z)-5);
			
			// if you want to smooth movement then lerp it

		}

	}

	void OnMouseDown(){
		isPicked = true;
	}
}
