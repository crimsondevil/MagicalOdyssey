using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpells : MonoBehaviour
{
    public GameObject projectile;
    public GameObject muzzle;
    public Transform firePoint;
    public Transform spellTarget;
    public float projectileSpeed = 10;
    public float arcRange = 1;
    //public ParticleSystem healProjectile;
    //public ThirdPersonMovement TPController;

    private Animator animator;
    private Vector3 destination;

    //private GameObject projectile;
    //private GameObject muzzle;
    //private string animationType = null;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Spawn is being called");
        //Ray ray = cam.ViewportPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
        Vector3 rayCastDirection = spellTarget.position - this.transform.position;
        Ray ray = new Ray(this.transform.position, rayCastDirection);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(1000);
        }
    }

    void InstantiateProjectile()
    {
        Debug.Log("Instantiate is being called");
        var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;

        iTween.PunchPosition(projectileObj, new Vector3(Random.Range(-arcRange, arcRange), Random.Range(-arcRange, arcRange), 0), Random.Range(0.5f, 2));

        var muzzleObj = Instantiate(muzzle, firePoint.position, Quaternion.identity) as GameObject;
        Destroy(muzzleObj, 2);
    }

    

}
