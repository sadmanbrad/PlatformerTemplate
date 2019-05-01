using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pickup : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") {
			OnPickup(other.gameObject);
			Destroy(this.gameObject);
		}
	}

	public virtual void OnPickup(GameObject player) {

	}
}
