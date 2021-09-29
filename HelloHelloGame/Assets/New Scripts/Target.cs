using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public Material glow;
    public Material nonglow;
    public GameObject smoke;

    public void TakeDamage(float amount)
    {
        gameObject.GetComponent<MeshRenderer>().material = glow;
        Invoke("BackToNormal",0.7f);
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        var smokeObj = Instantiate(smoke, this.transform.position, Quaternion.identity) as GameObject;
        Destroy(smokeObj, 2);
        /*while (gameObject.GetComponent<Renderer>().material.color.a > 0)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (0.4f * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;
        }*/
    }

    void BackToNormal()
    {
        gameObject.GetComponent<MeshRenderer>().material = nonglow;
    }

}
