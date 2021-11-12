using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XXXX: MonoBehaviour
{
	Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
	{
//		RaycastHit2D hit=Physics2D.Raycast(rbody.position,lookDirection,2f
//			,LayerMask.GetMask("house"));
	}
    }
}
