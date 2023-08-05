using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] PlayerAttack playerAttack;
    [SerializeField] Animator playerAnimator;

    public bool isRunning;
    public bool isJumping;
    public bool isAttacking;
    void Update()
    {
        playerAnimator.SetBool("IsJumping", isJumping);
        playerAnimator.SetBool("IsAttacking", isAttacking);
        playerAnimator.SetBool("IsRunning", isRunning);
    }
}
