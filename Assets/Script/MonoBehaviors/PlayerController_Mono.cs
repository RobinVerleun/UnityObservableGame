using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Mono : MonoBehaviour
{ 
    PlayerController pc;

    public void Init()
    {
        pc = new PlayerController(gameObject);
    }

	// Use this for initialization
	void Start () {
        Init();	
	}
	
	// Update is called once per frame
	void Update () {
        pc.MovePlayer();
	}
}
