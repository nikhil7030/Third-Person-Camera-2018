using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distructable : MonoBehaviour
{
    public GameObject distroyableObject;
    private void OnCollisionEnter(Collision collision)
    {

        Instantiate(distroyableObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
