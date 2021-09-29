using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject impactVFX;
    public float damage = 10f;

    private bool collided;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Spell" && collision.gameObject.tag != "Enemy" && !collided)
        {
            Debug.Log(collision.gameObject);
            collided = true;
            var impact = Instantiate(impactVFX, collision.contacts[0].point, Quaternion.identity) as GameObject;

            Destroy(impact, 2);
            Destroy(gameObject);

            Target target = collision.gameObject.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
