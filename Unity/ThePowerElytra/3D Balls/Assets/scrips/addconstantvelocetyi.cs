using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addconstantvelocetyi : MonoBehaviour
{

    [SerializeField]
    Vector3 v3Force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += new Vector3(0.1f, 0, 0);
    }
}
