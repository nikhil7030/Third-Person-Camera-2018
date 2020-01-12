using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.UI;

public class GameControls : MonoBehaviour
{
    public Controls Input_Master;
    public Throw_Controller weapon_moves;
    public Animator player_Animator;
    public MovementInput movement;
    public Combat combat;


    public bool aming;
    public bool Combatmode = false;
    private int count = 0;


    private float counter = 0;
    public float Horizontal;
    public float Vertical;
    private CinemachineFreeLook cin;
    [SerializeField]private Image CombatIcon;
    [SerializeField]private Image ThrowIcon;
    


    private void OnEnable()
    {
        Input_Master.Player.Enable();
    }
    private void OnDisable()
    {
        Input_Master.Player.Disable();
    }
    void throwAxe()
    {
        if (weapon_moves.hasWeapon == true)
        {
            weapon_moves.Throw_Weapon(true);
        }
        else
            return;
    }

    void Awake()
    {

        Input_Master = new Controls();
        


        Input_Master.Player.Aim.performed += ctx => {
            if (player_Animator.GetBool("Aim") == true)
            {
                return;
            }
            else
            {
                if (weapon_moves.hasWeapon == true && !movement.isSprinting)
                {

                    player_Animator.SetBool("Aim", true);
                    if (aming == true)
                    {
                        return;
                    }
                    else { aming = true; }

                    Debug.Log("Aming");

                }

                else if (weapon_moves.hasWeapon == false && !movement.isSprinting)
                {
                    player_Animator.SetBool("Catch", true);
                    //weapon_moves.Catch_Weapon(true);
                }
            }
        };

        Input_Master.Player.Aim.canceled += ctx =>
        {
            player_Animator.SetBool("Aim", false);
            if (aming != false)
            {
                aming = false;
            }

        };

    
        Input_Master.Player.Throw.performed += ctx =>
        {
            if (weapon_moves.hasWeapon == true && player_Animator.GetBool("Aim") == true && Combatmode == false)
            {
                player_Animator.SetTrigger("Throw");
                player_Animator.SetBool("Aim", false);
            }
            else if (weapon_moves.hasWeapon == true && Combatmode == true)
            {
                combat.ComboStarter();
                
            }

        };


            //if (player_Animator.GetBool("Aim") == true ) 
            //{
            //    player_Animator.SetTrigger("Throw");
            //    player_Animator.SetBool("Aim", false);
            //}

            //if (!player_Animator.GetBool("Aim") == true)
            //{
            //    player_Animator.SetTrigger("Attack1");
            //}

        //};
        //Input_Master.Player.Attack.performed += ctx =>
        //{

            

        //};





        Input_Master.Player.Pull.performed += ctx => weapon_moves.Catch_Weapon(true);


        Input_Master.Player.Roll.performed += ctx => 
        {
            //if (Horizontal != 0 || Vertical != 0)
            //{
                player_Animator.SetBool("Roll", true);
            //}
        };
        Input_Master.Player.Roll.canceled += ctx =>
        {
            
                player_Animator.SetBool("Roll", false);
            
        };


        Input_Master.Player.Equip_Axe.performed += ctx =>
        {
            if (counter == 0 && !weapon_moves.hasWeapon)
            {
                weapon_moves.Throw_Weapon(false);
                counter = 1;
            }
            else
            {
                weapon_moves.Catch_Weapon(false);
                counter = 0;
            }



        };

        Input_Master.Player.Sprint.performed += ctx =>
        {
            if (Input.GetAxis("Vertical") > 0.3f && !player_Animator.GetBool("_SprintAttack"))
            {
                //Debug.Log("Sprinting");
                movement.isSprinting = true;

            }

        };
        Input_Master.Player.Sprint.canceled += ctx =>
        {
            movement.isSprinting = false;
        };

        Input_Master.Player.CombatMode.performed += ctx =>
         {
      
             if (count == 0)
             {
                 Combatmode = true;
                 count = 1;
                 CombatIcon.enabled = true;
                 ThrowIcon.enabled = false;
             }
             else
             {
                 count = 0;
                 Combatmode = false;
                 enabled = true;
                 ThrowIcon.enabled = true;
                 CombatIcon.enabled = false;
             }
         };

        //Input_Master.Player.Walk_Up.performed += ctx =>
        //{
        //    Vertical = 1;
        //    if (isSprinting)
        //        player_Animator.SetFloat("PosX", 1f);
        //    else
        //        player_Animator.SetFloat("PosX", 0.5f);
        //};
        //Input_Master.Player.Walk_Up.canceled += ctx =>
        //{
        //    Vertical = 0;
        //    player_Animator.SetFloat("PosX", 0f);
        //};

        //Input_Master.Player.Walk_Down.performed += ctx =>
        //{
        //    Vertical = -1;
        //    if (isSprinting)
        //        player_Animator.SetFloat("PosX", 1f);
        //    else
        //        player_Animator.SetFloat("PosX", .5f);
        //};
        //Input_Master.Player.Walk_Down.canceled += ctx =>
        //{
        //    Vertical = 0;
        //    player_Animator.SetFloat("PosX", 0f);
        //};

        //Input_Master.Player.Walk_Left.performed += ctx =>
        //{
        //    Horizontal = -1;
        //    if (isSprinting)
        //        player_Animator.SetFloat("PosX", 1f);
        //    else
        //        player_Animator.SetFloat("PosX", .5f);
        //};
        //Input_Master.Player.Walk_Left.canceled += ctx =>
        //{
        //    Horizontal = 0;

        //};

        //Input_Master.Player.Walk_Right.performed += ctx =>
        //{
        //    Horizontal = 1;
        //    if (isSprinting)
        //        player_Animator.SetFloat("PosX", 1f);
        //    else
        //        player_Animator.SetFloat("PosX", .5f);
        //};
        //Input_Master.Player.Walk_Right.canceled += ctx =>
        //{
        //    Horizontal = 0;

        //};



    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(aming);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
