using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    public Collider mainCollider;
    public Collider[] AllColliders;
    public Animator animator;
    public Transform Mesh;
    
    private bool ragDollState;
    void Start()
    {
        Mesh = GetComponent<Transform>();
        AllColliders = GetComponentsInChildren<Collider>(true);
        mainCollider = GetComponent<Collider>();
        //animator = this.GetComponent<Animator>();
        DoRagdoll(false);
        

    }

    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Weapon") )
        {
            Debug.Log("HIt By Axe");
            //animator.SetTrigger("Hit");
            DoRagdoll(true);
        }


    }

    public void DoRagdoll(bool isRagdoll)
    {
        //Debug.Log("Turning On Ragdoll");
        foreach (var col in AllColliders)
        {
            //col.isTrigger = !isRagdoll;
        }
        //mainCollider.enabled = true;
        
        animator.enabled = !isRagdoll;



    }
    
    void Update()
    {
        
    }
}
