using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCube : MonoBehaviour {

	private static SpawnedCube prefab
    {
        get { return Resources.Load<SpawnedCube>("Prefabs/SpawnedCube"); }
    }

    public static void CreateFromPrefab(Transform spawner)
    {
        SpawnedCube cube = Instantiate(prefab);

        Vector3 location = cube.transform.position;
        location.x = spawner.position.x;
        location.z = spawner.position.z + GameValues.Spawners.spawnDistance;

        cube.transform.position = location; 
    } 


}
