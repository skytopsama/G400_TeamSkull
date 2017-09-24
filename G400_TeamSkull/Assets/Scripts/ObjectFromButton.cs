using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFromButton : MonoBehaviour {
	public GameObject room;

	private GameObject roomInstance; 
	private bool roomGrabbed;

	// Use this for initialization
	void Start () {
		roomGrabbed = false;
	}
		
	
	// Update is called once per frame
	void Update () {
		if (roomInstance != null && roomGrabbed== true)
		{
			var mousePos = Input.mousePosition;
			mousePos.z = -Camera.main.transform.position.z;

			
		}

//		if (roomGrabbed != && spawn != null) {
//			var pos = Input.mousePosition;
//			pos.z = -Camera.main.transform.position.z;
//
//			spawn.transform.position = Camera.main.ScreenToWorldPoint(pos);
//
//			Instantiate (prefab, pos, Quaternion.identity);
//		}
//
		if (Input.GetMouseButtonUp(0)) {
			Debug.Log ("input");
		}

	}
		
	void OnMouseOver(){
		Debug.Log ("mouse over");
		roomGrabbed = true;
		roomInstance = Instantiate (room, transform.position, Quaternion.identity);
	}
}
