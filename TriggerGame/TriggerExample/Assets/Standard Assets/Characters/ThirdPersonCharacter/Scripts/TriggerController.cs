using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerController : MonoBehaviour {
    
    int tmp;
    private void Update()
    {
        if (tmp==1)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            tmp = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            tmp = 0;
        }
    }
}
