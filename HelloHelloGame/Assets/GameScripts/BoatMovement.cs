using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement: MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.1f;
    public float rateturn = 100f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        float mhor = Input.GetAxis("Horizontal");
        float mver = Input.GetAxis("Vertical");
        mhor = 1;
        mver = 1;
        Debug.Log("update");
        Debug.Log("mhor"+mhor);
        Debug.Log("mver" + mver);
        Vector3 motion = new Vector3(mhor, 0.0f, mver);
       // rb.AddTorque(0f, mhor * speed * Time.deltaTime, 0f);
        rb.AddForce(motion * speed * rateturn * Time.deltaTime);
    }
}
