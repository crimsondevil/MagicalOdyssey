using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sailor;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - sailor.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = sailor.transform.position + offset;
    }
}
