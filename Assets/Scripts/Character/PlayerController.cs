using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private SimpleCharacterController2D character;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		character.Walk(Input.GetAxis("Horizontal"));
		if (Input.GetButtonDown("Jump")) {
			character.Jump();
		}
	}
}
