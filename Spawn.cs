using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	// The Monster that should be spawned
	public GameObject trashPrefab;
	
	// Spawn Delay in seconds
	public float interval = 5;
	
	// Use this for initialization
	void Start() {
		InvokeRepeating("SpawnNext", interval, interval);
	}
	
	void SpawnNext() {
		Instantiate(trashPrefab, transform.position, Quaternion.identity);
	}
}