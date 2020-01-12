
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script requires you to have setup your animator with 3 parameters, "InputMagnitude", "InputX", "InputZ"
//With a blend tree to control the inputmagnitude and allow blending between animations.
[RequireComponent(typeof(CharacterController))]
public class MovementInput : MonoBehaviour {

	public float InputX;
	public float InputZ;
    public float stopTime = 1f;
	public Vector3 desiredMoveDirection;
    
	
	public float desiredRotationSpeed = 0.1f;
	public Animator anim;
	public float Speed;
	public float allowPlayerRotation = 0.1f;
	public Camera cam;
	public CharacterController controller;
    public GameObject weapon;

	public bool isGrounded = true;
    private bool atEdge;
    public bool isSprinting;
    public bool blockRotationPlayer;
    public bool canVault;


    [Header("Animation Smoothing")]
    [Range(0, 1f)]
    public float HorizontalAnimSmoothTime = 0.2f;
    [Range(0, 1f)]
    public float VerticalAnimTime = 0.2f;
    [Range(0,1f)]
    public float StartAnimTime = 0.3f;
    [Range(0, 1f)]
    public float StopAnimTime = 0.15f;


    private float verticalVel;
    private Vector3 moveVector;
    private Vector3 whilejump;

	// Use this for initialization
	void Start () {
        whilejump = new Vector3(0, 2, 0);
        anim = this.GetComponent<Animator> ();
		cam = Camera.main;

		controller = this.GetComponent<CharacterController> ();
        isGrounded = true;
	}

    // Update is called once per frame
    void Update() {
        InputMagnitude();
        //for (int i = 1; i == 0; i++)
        //{
        //    stopTime -= InputZ;
        //    Debug.Log(stopTime);
        //}

        //Debug.Log("Can Vault: " + canVault);


        //If character isn't grounded then get rid of this part.
        isGrounded = controller.isGrounded;
        if (isGrounded)
        {
            verticalVel -= 0;
        }
        else
        {
            verticalVel -= 2;
        }
        moveVector = new Vector3(0, verticalVel, 0);
        controller.Move(moveVector);

        //Updater
        //if (isGrounded)
        //{
        //    anim.SetBool("IsFalling", false);
        //}
        //else 
        //{
        //    anim.SetBool("IsFalling", true);
        //}

        

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Environment"))
    //    {
    //        Debug.Log("Landed");
    //        anim.SetBool("IsFalling", false);
    //    }
    //}

    void PlayerMoveAndRotation() {
		InputX = Input.GetAxis ("Horizontal");
		InputZ = Input.GetAxis ("Vertical");

		var camera = Camera.main;
		var forward = cam.transform.forward;
		var right = cam.transform.right;

		forward.y = 0f;
		right.y = 0f;

		forward.Normalize ();
		right.Normalize ();

		desiredMoveDirection = forward * InputZ + right * InputX;

		if (blockRotationPlayer == false) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (desiredMoveDirection), desiredRotationSpeed);
		}
	}

	void InputMagnitude() {
		//Calculate Input Vectors
		InputX = Input.GetAxis ("Horizontal");
		InputZ = Input.GetAxis ("Vertical");

		anim.SetFloat ("InputZ", InputZ, VerticalAnimTime, Time.deltaTime * 2f);
		anim.SetFloat ("InputX", InputX, HorizontalAnimSmoothTime, Time.deltaTime * 2f);

		//Calculate the Input Magnitude
		Speed = new Vector2(InputX, InputZ).sqrMagnitude;

		//Physically move player
		if (Speed > allowPlayerRotation) {
			anim.SetFloat ("InputMagnitude", Speed, StartAnimTime, Time.deltaTime);
			PlayerMoveAndRotation ();
		} else if (Speed < allowPlayerRotation) {
			anim.SetFloat ("InputMagnitude", Speed, StopAnimTime, Time.deltaTime);
		}

        if (isSprinting)
        {
            anim.SetFloat("InputMagnitude", Speed + 8, StartAnimTime, Time.deltaTime);
            anim.SetBool("_IsSprinting",true);
            
        }
        else 
        {
            anim.SetBool("_IsSprinting",false);
        }
	}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Edge"))
    //    {

    //        Debug.Log("On The Edge");
    //    }

    //    if (other.gameObject.CompareTag("Player"))
    //    {

    //        anim.SetBool("Jump", false);

    //        Debug.Log("On Floor");
    //    }
    //    Debug.Log(other.gameObject.tag);
    //}

    public void SprintAttackComplete()
    {
        anim.SetBool("_SprintAttack",false);
        anim.SetBool("_IsSprinting", false);
    }

    private void OnTriggerStay(Collider target)
    {
        if (target.tag == "Obstracle")
        {
            if (Input.GetKeyDown("space"))
            {
                canVault = true;
                //Debug.Log("Pressed C");
                anim.SetBool("Jump", true);
                
                controller.enabled = false;
                weapon.GetComponent<BoxCollider>().enabled = false;
                weapon.GetComponent<CapsuleCollider>().enabled = false;
            }
            
            //Debug.Log("Can Vault :" + canVault);
        }
        else if (target.tag == "ObstracleHigh")
        {
            if (Input.GetKeyDown("space"))
            {
                canVault = true;
                anim.SetBool("JumpHigh", true);
                controller.enabled = false;

                weapon.GetComponent<BoxCollider>().enabled = false;
                weapon.GetComponent<CapsuleCollider>().enabled = false;
            }
        }


    }


    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
    }

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Obstracle"))
    //    {
    //        canVault = false;
    //    }
    //}


    private void OnTriggerEnter(Collider other)
    {

        
            //if (other.tag == "Obstracle")
            //{
            //    anim.SetBool("Jump", true);
            //    controller.enabled = false;
            //    weapon.GetComponent<BoxCollider>().enabled = false;
            //    weapon.GetComponent<CapsuleCollider>().enabled = false;

            //}
            //else if (other.tag == "ObstracleHigh")
            //{
            //    anim.SetBool("JumpHigh", true);
            //    controller.enabled = false;
            //}
        
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Obstracle")
        {
            canVault = false;
            //controller.enabled = true;
            //Debug.Log("Can Vault :" + canVault);
        }
        if (target.tag == "ObstracleHigh")
        {
            canVault = false;
            //controller.enabled = true;
            //Debug.Log("Can Vault :" + canVault);
        }
    }

    public void JumpComplete(string clip)
    {
        anim.SetBool(clip, false);
        controller.enabled = true;
        weapon.GetComponent<BoxCollider>().enabled = true;
        weapon.GetComponent<CapsuleCollider>().enabled = true;
    }
}
