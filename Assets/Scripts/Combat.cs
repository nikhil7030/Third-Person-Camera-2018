using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] private TrailRenderer trail;
    [SerializeField] private ParticleSystem trailparticales;
    private Animator animator;
    

    public int noOfClicks; //Determines Which Animation Will Play
    public bool canClick; //Locks ability to click during animation event

    void Start()
    {
        //Initialize appropriate components
        animator = this.GetComponent<Animator>();

        noOfClicks = 0;
        canClick = true;
    }

    void Update()
   {
    //    if(controls.Combatmode) 
    //    {
    //        Debug.Log("Can Fight");
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            ComboStarter();
    //        }
    //    }
    }

    public void ComboStarter()
    {
        if (canClick)
        {
            noOfClicks++;
        }

        if (noOfClicks == 1)
        {
            trail.emitting = true;
            //trailparticales.Play();
            animator.SetInteger("Attack", 31);
        }
    }

    public void ComboCheck()
    {

        canClick = false;

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_1") && noOfClicks == 1)
        {
            //If the first animation is still playing and only 1 click has happened, return to idle
            animator.SetInteger("Attack", 4);
            canClick = true;
            noOfClicks = 0;
            trail.emitting = false;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_1") && noOfClicks >= 2)
        {
            //If the first animation is still playing and at least 2 clicks have happened, continue the combo          
            animator.SetInteger("Attack", 33);
            canClick = true;
        }


        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_2") && noOfClicks == 2)
        {  
            //If the second animation is still playing and only 2 clicks have happened, return to idle         
            animator.SetInteger("Attack", 4);
            canClick = true;
            noOfClicks = 0;
            trail.emitting = false; 
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_2") && noOfClicks >= 3)
        {  
            //If the second animation is still playing and at least 3 clicks have happened, continue the combo         
            animator.SetInteger("Attack", 6);
            canClick = true;
        }


        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_3") && noOfClicks == 3)
        { 
            //If the Third animation is still playing and only 3 clicks have happened, return to idle     
            animator.SetInteger("Attack", 4);
            canClick = true;
            noOfClicks = 0;
            trail.emitting = false;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_3") && noOfClicks >= 4)
        { 
            //If the Third animation is still playing and at least 3 clicks have happened, continue the combo          
            animator.SetInteger("Attack", 7);
            canClick = true;
            GetComponent<CharacterController>().enabled = false;
        }

        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_4") && noOfClicks >= 4)
        { 
            //Since this is the Fourth and last animation, return to idle          
            animator.SetInteger("Attack", 4);
            canClick = true;
            noOfClicks = 0;
            trail.emitting = false;
            GetComponent<CharacterController>().enabled = true;
        }

    }
}

