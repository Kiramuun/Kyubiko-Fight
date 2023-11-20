using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        #region Attack Ahri
        animator.SetBool("attackSplash", false);
        animator.SetBool("attackFireball", false);
        animator.SetBool("Ultimate", false);
        #endregion
        #region Attack Chevaliere
        animator.SetBool("slashVerti", false);
        animator.SetBool("Estoc", false);
        animator.SetBool("ultiTornado", false);
        #endregion
        #region Attack Corbeau
        animator.SetBool("Cslash", false);
        animator.SetBool("Cslash2", false);
        animator.SetBool("CslashChargé", false);
        #endregion
        #region Attack Tengu
        animator.SetBool("Tslash", false);
        animator.SetBool("Tslash2", false);
        animator.SetBool("TslashChargé", false);
        #endregion
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
