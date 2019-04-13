using UnityEngine;
using UnityEngine.UI;

public class CarSpawner : MonoBehaviour {

	public static float spawnDelay = .3f;

	public GameObject car;
	public Transform[] spawnPoints;
	float nextTimeToSpawn = 0f;
    public static float scale;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];
        ScaleCar();
		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
	}

    void ScaleCar()
    {
        car.transform.localScale = new Vector3(scale, scale, scale);
    }

}
