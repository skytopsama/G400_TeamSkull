using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int gridSize;
	public GameObject groundTile;
	public GameObject playerTile;

	// Use this for initialization
	void Start () {
		//Builds a grid
		Transform tileTransform = groundTile.GetComponentsInChildren<Transform>(true)[0];
		Quaternion tileRotation = tileTransform.rotation;
		for (int i = 0; i < gridSize; i++) {
			for (int j = 0; j < gridSize; j++) {
				var newTile = Instantiate (groundTile, new Vector3 (i, 0, j), tileRotation);
				newTile.transform.parent = GameObject.Find ("Map Grid").transform;
			}
		}

		GameObject.Find ("Map Grid").transform.position = new Vector3 (-(gridSize / 2), 0, -(gridSize / 2));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
