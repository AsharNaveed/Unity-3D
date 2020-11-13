using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class PlayerController : MonoBehaviour
{
    private int count;
    public Text countText;
    void Start()
    {
        count = 0;
        CountText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            CountText();
        }
        if (other.gameObject.tag == "Hazard")
        {
            other.gameObject.SetActive(false);
            Vector3 jump = new Vector3(0.0f, 30, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump * speed * Time.deltaTime);
        }

    }

    void CountText ()
    {
        countText.text = "Score: " + count;
    }


    public float speed;
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    
}
