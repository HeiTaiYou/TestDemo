using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action: MonoBehaviour
{
		public float speed =0.55f;
		Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.right *speed *Time.deltaTime);
	float moveX = Input.GetAxisRaw("Horizontal");
float moveY=Input.GetAxisRaw("Vertical");
Vector2 positon =body.position;
//transform.position;
positon.x+=moveX*speed*Time.deltaTime;
positon.y+=moveY*speed*Time.deltaTime;
//transform.position =positon;
body.MovePosition(positon);
    }
}
