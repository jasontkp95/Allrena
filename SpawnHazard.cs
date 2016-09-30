using UnityEngine;
using System.Collections;

public class SpawnHazard : MonoBehaviour {
    public Transform SpawnObject;
	public int numOfHazards;
    public float spawnTime = 1.5f;
	public float spawnRate;

    //public GameObject Hazards;

	// Use this for initialization
    void Start () {
		//numOfHazards = 2;
        InvokeRepeating("SpawnHazards", spawnTime, spawnRate);
	}
	
	// Update is called once per frame
    void Update () {
        
	}

    void SpawnHazards()
    {
		for (int i = 0; i <= Random.Range(0, numOfHazards); i++)
        {
            float x = Random.Range(-4f, 4f);
            float y = Random.Range(-4f, 4f);
            Vector2 position = new Vector2(x, y);
            Instantiate(SpawnObject, position, SpawnObject.rotation);
        }
    }
}
