using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int gridSize;
	public GameObject groundTile;

	// Use this for initialization
	void Start () {
		Transform tileTransform = groundTile.GetComponentsInChildren<Transform>(true)[0];
		Quaternion tileRotation = tileTransform.rotation;
		for (int i = 0; i < gridSize; i++) {
			for (int j = 0; j < gridSize; j++) {
				var newTile = Instantiate (groundTile, new Vector3 (i, j, 0), tileRotation);
				newTile.transform.parent = GameObject.Find ("Map Grid").transform;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
