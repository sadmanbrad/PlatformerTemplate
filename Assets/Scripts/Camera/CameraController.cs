using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	[SerializeField]
	Transform target;

	[SerializeField]
	[Range(0,1)]
	float speed;

	Vector2 vel = Vector2.zero;

    // LateUpdate is called once per frame after all Updates were called
    void LateUpdate()
    {
		Vector2 pos = transform.position;
		pos = Vector2.Lerp(pos, target.position, speed*speed);
		transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
