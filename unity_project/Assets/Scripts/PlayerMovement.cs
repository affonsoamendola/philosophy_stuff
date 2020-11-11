using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Vector2 current_pos;
	Vector2 movement_direction;

	public float speed = 0.05f;

	void Awake()
	{
		current_pos = gameObject.transform.position;
		movement_direction = new Vector2(0.0f, 0.0f);
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	movement_direction.x = Input.GetAxis("Horizontal");
    	movement_direction.y = Input.GetAxis("Vertical");

       	MovePlayer(movement_direction);
    }

    void MovePlayer(Vector2 direction)
    {
 		gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }
}
 