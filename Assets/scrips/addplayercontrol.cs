using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addplayercontrol : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode KeyPositive;
    [SerializeField]
    KeyCode KeyNegative;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyPositive))
        GetComponent<Rigidbody>().velocity += v3Force;
        
        if (Input.GetKey(KeyNegative))
        GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
