using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dikey input alındı
        horizontalInput = Input.GetAxis("Horizontal");
        //yata input alındı
        VerticalInput = Input.GetAxis("Vertical");
        //ileri - geri
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        //sağ sol
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
