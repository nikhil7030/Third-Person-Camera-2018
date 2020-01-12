using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWeaponScript : MonoBehaviour
{
    public bool activated; //To know if wepon is spinning
    private int Hit = 0; // How many times weapon hit something
    public EnemyMovements enemyMovements;
    private AudioSource audioSource;
    public AudioClip splash; //Water splash clip
    public AudioClip wip; //Wip Clip
    public AudioClip metalWip; //Metal spinning
    public AudioClip wood_Hit; //Hit the Wooden surface
    public AudioClip metal_Hit; //Hit metal surface 

    public float rotationSpeed; //Weapon rotation speed
    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        
    }

    void Update()
    {

        if (activated)  // To activate Axe Spinning
        {
            
            transform.localEulerAngles += Vector3.forward * rotationSpeed * Time.deltaTime;

        }


    }

    private void OnCollisionEnter(Collision collision) 
    {
        //Debug.Log(collision.gameObject.tag);
         
        audioSource.Stop();
        if (collision.gameObject.CompareTag("Wood"))
        {
            if (Hit == 0) //first wepaon hit
            {
                activated = false; //stop spinning
                audioSource.PlayOneShot(wood_Hit, 1.0f); //play wood hit clip
                Hit = 1; 
                //audioSource.Play();
                return;

            }
            else if(Hit == 1) //on second weapon hit
            {
                //print(collision.gameObject.name);
                GetComponent<Rigidbody>().Sleep();
                GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
                GetComponent<Rigidbody>().isKinematic = true;
                activated = false;
                transform.parent = null;
                audioSource.PlayOneShot(wood_Hit, 1.0f);
                Hit = 0;
            }
        }
        if (collision.gameObject.CompareTag("Metal"))
        {
            //print(collision.gameObject.name);
            GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            GetComponent<Rigidbody>().mass = 10f;
      
            activated = false;
            Hit = 1;
            transform.parent = null; // detach weapon
            audioSource.PlayOneShot(metal_Hit,1.0f);


        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //print(collision.gameObject.name);
            GetComponent<Rigidbody>().Sleep();
            GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            //GetComponent<Rigidbody>().isKinematic = true;
            activated = false;
            Hit = 1;
            transform.parent = enemyMovements.Mesh.transform; // attach weapon

            Debug.Log(collision.gameObject.name);

        }
        if (collision.gameObject.CompareTag("Water"))
        {
            //print(collision.gameObject.name);
            GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            activated = false;
            Hit = 1;
            
            audioSource.PlayOneShot(splash, 1.0f);
            GetComponent<Rigidbody>().isKinematic = true;  //To freeze weapon
        }
        
        if(collision.gameObject.CompareTag("Obstracle"))
        {
            //print(collision.gameObject.name);
            GetComponent<Rigidbody>().Sleep();
            GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
            GetComponent<Rigidbody>().isKinematic = true;
            activated = false;
            transform.parent = null;
            audioSource.PlayOneShot(wood_Hit, 1.0f);
            Hit = 0;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Rigidbody>().mass = 1f;
        Hit = 0;
    }


    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
        
    }

    public void playWip(bool _start)
    {
        if (_start)
        {
            //audioSource.PlayOneShot(splash, 1.0f);
        }
        else if (!_start)
        {
            audioSource.PlayOneShot(wip, 1.0f);
            audioSource.PlayOneShot(metalWip, 0.1f);

            //audioSource.Play();
            //StartCoroutine(FadeOut(audioSource,0.4f));


        }
    }
}
