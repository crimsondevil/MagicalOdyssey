using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShipFront : MonoBehaviour
{
    public float speed = 2f;
    public float rateturn = 100f;


    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("NextScene", 10f);//invoke after 5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        float mhor = Input.GetAxis("Horizontal");
        float mver = Input.GetAxis("Vertical");
        mhor = 1;
        mver = 1;
        Debug.Log("update");
        Debug.Log("mhor" + mhor);
        Debug.Log("mver" + mver);
        Vector3 motion = new Vector3(mhor, 0.0f, mver);
        // rb.AddTorque(0f, mhor * speed * Time.deltaTime, 0f);
        rb.AddForce(motion * speed * rateturn * Time.deltaTime);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
