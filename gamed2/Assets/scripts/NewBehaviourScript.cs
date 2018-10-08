using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject jugador;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z-10);
	}
}
