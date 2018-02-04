using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//public speeds
   public float rotateSpeed = 180.0f;
   public float speed = 5.0f;
	// declaring a transform varable
	private Transform Tf;
    void Start()
    {
		Tf = GetComponent<Transform> ();
    }
    // Update is called once per frame
    void Update() {
		// setting the speeds that it can rotate at
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;
		//moving it forward
        if (Input.GetKey(KeyCode.UpArrow))
            {
			Tf.Translate ( transAmount, 0,0);

        }
		// checking for rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {

			Tf.Rotate(0, 0 ,-rotateAmount);
        }
		// checking for rotation
        if (Input.GetKey(KeyCode.RightArrow))
        {

			Tf.Rotate(0,0 , rotateAmount);
        }
    }
}
