using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArrow : MonoBehaviour
{
    public Transform finalposi;

    void Update()
    {
        transform.LookAt(finalposi);
    }
}
