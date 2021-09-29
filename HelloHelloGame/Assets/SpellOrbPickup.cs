using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellOrbPickup : MonoBehaviour
{
    public GameObject parentObjRef;
    public AudioSource OrbPickup;
    public GameObject spell_Canvas;

    public Shooter shooter;
    public GameObject projectile;
    public GameObject muzzle;
    public string animationType;

    private void OnTriggerEnter(Collider other)
    {
        OrbPickup.volume = Random.Range(0.8f, 1f);
        OrbPickup.pitch = Random.Range(0.8f, 1.1f);
        OrbPickup.Play();

        parentObjRef.SetActive(false);

        spell_Canvas.SetActive(true);

        shooter.SetShootingObjects(projectile, muzzle, animationType);
    }

}

