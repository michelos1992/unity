using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sterowanie : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public Rigidbody projectile;
    Rigidbody rb;
    public Transform shotPos;
    public float shotForce = 100f;
    public float moveSpeed = 100f;
    public float jumpHeight = 1000f;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
 //       float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
 //       float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //float jump = 0.0f;
        //if (Input.GetButtonDown("Jump"))
        //{
        //    jump = jumpHeight * Time.deltaTime * moveSpeed;
        //    rb.AddForce(new Vector3(0, jump, 0));
        //}
        //transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime);
        //transform.Translate(new Vector3(h, 0, v));

        //// Create some bullets
        //if (Input.GetButtonUp("Fire1"))
        //{
        //    Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
        //    shot.AddForce(shotPos.forward * shotForce);
        //}
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}