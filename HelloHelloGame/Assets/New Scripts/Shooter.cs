using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Camera cam;
    public Image crosshair;
    //public GameObject projectile;
    //public GameObject muzzle;
    public Transform firePoint;
    public Transform spellTarget;
    public float projectileSpeed = 10;
    public float arcRange = 1;
    //public ThirdPersonMovement TPController;

    private Animator animator;
    private Vector3 destination;

    private GameObject projectile;
    private GameObject muzzle;
    private string animationType=null;

    public AudioSource PlayerAudioSource;
    public AudioClip CastSpellAudio;

    // Start is called before the first frame update
    void Start()
    {
        crosshair.enabled = false;
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

        if (animationType != null)
        {
            crosshair.enabled = true;
            crosshair.transform.position = cam.WorldToScreenPoint(destination);
        }
    }

    public void SpawnVFX()
    {
        if (animationType != null)
        {
            //TPController.ActivateSpell(2);

            //animator.Play("New_Attack_1");
            //Quaternion lookRotation = Quaternion.LookRotation((spellTarget.position-transform.position).normalized);
            //var oldRotation = transform.rotation;
            //transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1);
            //this.transform.LookAt(spellTarget);

            animator.Play(animationType);

            if (PlayerAudioSource.isPlaying == false)
            {
                PlayerAudioSource.volume = Random.Range(0.4f, 0.6f);
                PlayerAudioSource.pitch = Random.Range(0.8f, 1.1f);
                PlayerAudioSource.PlayOneShot(CastSpellAudio);
            }

            //transform.rotation = oldRotation;
            //InstantiateProjectile();
        }
    }

    void InstantiateProjectile()
    {
        //Debug.Log("Instantiate is being called");
        var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;

        iTween.PunchPosition(projectileObj, new Vector3(Random.Range(-arcRange,arcRange),Random.Range(-arcRange,arcRange),0),Random.Range(0.5f,2));

        var muzzleObj = Instantiate(muzzle, firePoint.position, Quaternion.identity) as GameObject;
        Destroy(muzzleObj, 2);
    }

    public void SetShootingObjects(GameObject projectile,GameObject muzzle,string animationType)
    {
        this.projectile = projectile;
        this.muzzle = muzzle;
        this.animationType = animationType;
    }
}
