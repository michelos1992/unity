using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	public float speed;
    public Text CountText;
    public Text WinText;

    private Rigidbody rigidbody;
    private int count;

    void Start()
    {
		rigidbody = GetComponent<Rigidbody> ();
        count = 0;
        SetCountText();
    }

    private void SetCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if(count >= 9)
        {
            WinText.text = "You WIN!";
        }
    }

    void FixedUpdate ()
    {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Cylinder"))
        {
            other.gameObject.SetActive(false);
            count = count + 4;
            SetCountText();
        }
    }
}
