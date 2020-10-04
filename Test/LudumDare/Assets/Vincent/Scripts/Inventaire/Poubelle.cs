using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poubelle : MonoBehaviour
{
    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Destroy");
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(particles, transform.position, particles.transform.rotation);
        Destroy(gameObject);
            
    }
}
