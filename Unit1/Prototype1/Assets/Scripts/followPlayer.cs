using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 diff = new Vector3(0,5,-6);   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Kameranın pozisyonunu değiştiriyor.
       transform.position = Player.transform.position + diff; 
    }
}
