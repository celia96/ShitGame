using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {
	
	public float spawnWidth;
	[Tooltip("How many shits spawn per second?")]
	public float spawnRate;
	[Tooltip("The prefab that is to be instantiated as shits")]

	public List<GameObject> prefabList = new List<GameObject>();
	public GameObject ShitPrefab;
	public GameObject ToiletPaperPrefab;
	public GameObject CashPrefab;

	private int list_index;
	private float lastSpawnTime = 0;
	// Use this for initialization
	void Start () {
		prefabList.Add(ShitPrefab);
		prefabList.Add(ShitPrefab);
		prefabList.Add(CashPrefab);
		prefabList.Add(ShitPrefab);
		prefabList.Add(ShitPrefab);
		prefabList.Add(ShitPrefab);
		prefabList.Add(ToiletPaperPrefab);
		prefabList.Add(ShitPrefab);
	}
	
	// Update is called once per frame
	void Update () {
		// this is a simple timer structure that executes every 1/spawnRate seconds. This means it spawns spawnRate asteroids every second.
		if (lastSpawnTime + 1 / spawnRate < Time.time) {
			list_index = Random.Range (0, 8);
			lastSpawnTime = Time.time;
			Vector3 spawnPosition = transform.position;
			spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), 0, 0);
			// the Instatiate function creates a new GameObject copy (clone) from a Prefab at a specific location and orientation.
			Instantiate(prefabList[list_index], spawnPosition, Quaternion.identity);
		}
	}



}
