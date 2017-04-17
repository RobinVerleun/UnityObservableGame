using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner_Mono : MonoBehaviour {

    ObjectSpawner os;

	// Use this for initialization
	void Start () {
        os = new ObjectSpawner(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        os.CheckAndHandleMouseClicks();
	}
}
