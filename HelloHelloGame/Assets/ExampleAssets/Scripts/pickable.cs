using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickable : MonoBehaviour
{
    public GameObject parent_ref;
    public AudioSource ItemPickup;
    
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    private void OnTriggerEnter(Collider other)
    {
        ItemPickup.volume = Random.Range(0.25f, 0.3f);
        ItemPickup.pitch = Random.Range(0.8f, 1.1f);
        ItemPickup.Play();

        parent_ref.SetActive(false);
    }
}
