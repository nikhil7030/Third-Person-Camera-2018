using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Controller : MonoBehaviour
{
    //Weapon Positions to Swap
    private Vector3 weaponPosInHand = new Vector3(0.1f, -0.04f, 0.4f);
    private Vector3 weaponRotInHand = new Vector3(88.7f, 180.0f, 180.0f);
    private Vector3 weaponPosOnBack = new Vector3(0.0f, 0.2f, -0.2f);
    private Vector3 weaponRotOnBack = new Vector3(352.9f, 166.1f, 347.0f);
    private Vector3 pullPosition;
    [SerializeField]private UI ui;

    [SerializeField]
    private float Throw_Power = 100;
    private float returnTime;

    [Header("Bools")]
    public bool isPulling = false;
    public bool whereToPut;
    public bool hasWeapon = true;

    [Header("Game Objects")]
    public Transform weapon;
    public Transform hand;
    public Rigidbody weaponRB;
    public OnWeaponScript OnWeaponScript;
    public Transform curve;
    public Transform spine;
    public GameControls GameControls;
    public Animator animator;
    public AudioSource audioSourceWeapon;
    

    public ParticleSystem Glow;
    public ParticleSystem trailparticales;
    public ParticleSystem CatchSplark;
    public TrailRenderer trail;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
        trail.emitting = false;
    }

    
    void Update()
    {
        //animator.SetBool("HasAxe",hasWeapon);
        //Debug.Log(Input.GetAxis("Horizontal"));
        
        if (isPulling)
        {
            
            if (returnTime < 1)
            {
                weapon.position = GetQuadraticCurvePoint(returnTime, pullPosition, curve.position, hand.position);
                returnTime += Time.deltaTime * 1.5f;
            }
            else if (returnTime < 0.5f)
            {
                OnWeaponScript.activated = false;
            }
            else
            {
                WeaponCatched(whereToPut);
            }
        }


        animator.SetBool("HasAxe", hasWeapon);
        ui.WeaponUI(hasWeapon);


    }
    public void Throw_Weapon(bool OnAir)
    {
        if (OnAir && hasWeapon)
        {
            //Debug.Log("if");
            weaponRB.isKinematic = false;
            weaponRB.collisionDetectionMode = CollisionDetectionMode.Continuous;
            weapon.parent = null;
            //weapon.eulerAngles = new Vector3(0, -90 + transform.eulerAngles.y, 0);
            weapon.transform.position += transform.right / 5;
            weaponRB.AddForce(Camera.main.transform.forward * Throw_Power + transform.up * 2, ForceMode.Impulse);
            OnWeaponScript.activated = true;
            hasWeapon = false;
            whereToPut = true;
            trail.emitting = true;
            trailparticales.Play();
            OnWeaponScript.playWip(false);


        }
        else if(!OnAir && !hasWeapon)
        {
            //Debug.Log("fromelse");
            pullPosition = weapon.position;
            weaponRB.isKinematic = true;
            weaponRB.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            isPulling = true;
            OnWeaponScript.activated = true;
            hasWeapon = false;
            whereToPut = false;
            //trail.emitting = true;
            trailparticales.Play();
            OnWeaponScript.playWip(false);
        }
    }

    public void Catch_Weapon(bool bl)
    {
        pullPosition = weapon.position;
        weaponRB.isKinematic = true;
        weaponRB.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        isPulling = true;
        hasWeapon = false;
        OnWeaponScript.activated = true;
        whereToPut = bl;
        OnWeaponScript.playWip(false);
    }

    public void Perform_catch()
    {
        Catch_Weapon(true);

    }

    public void WeaponCatched(bool inhand)
    {
        if (inhand)
        {
            returnTime = 0f;
            weapon.transform.parent = hand;
            OnWeaponScript.activated = false;
            weapon.localPosition = weaponPosInHand;
            weapon.localEulerAngles = weaponRotInHand;
            isPulling = false;
            OnWeaponScript.activated = false;
            hasWeapon = true;
            CatchSplark.Play();
            trail.emitting = false;
            trailparticales.Stop();
            animator.SetBool("Catch", false);
            audioSourceWeapon.Pause();
            
        }
        else
        {
            returnTime = 0f;
            weapon.transform.parent = spine;
            OnWeaponScript.activated = false;
            weapon.localPosition = weaponPosOnBack;
            weapon.localEulerAngles = weaponRotOnBack;
            isPulling = false;
            OnWeaponScript.activated = false;
            hasWeapon = false;
            CatchSplark.Play();
            trail.emitting = false;
            trailparticales.Stop();
            audioSourceWeapon.Pause();

        }
    }


    public Vector3 GetQuadraticCurvePoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        return (uu * p0) + (2 * u * t * p1) + (tt * p2);
    }




    
}