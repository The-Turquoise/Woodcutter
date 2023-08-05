using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private PlayerAnimation anim;
    [SerializeField] private bool isAttacking;
    [SerializeField] private GameObject attackCol;
    [SerializeField] private float attackDuration;
    [SerializeField] private float timePassedAttacking;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isAttacking)
        {
            attackCol.SetActive(true);
            isAttacking = true;
            anim.isAttacking = true;
        }
        if (isAttacking)
        {
            timePassedAttacking += Time.deltaTime;
            if (timePassedAttacking >= attackDuration)
            {
                attackCol.SetActive(false);
                isAttacking = false;
                anim.isAttacking = false;
                timePassedAttacking = 0;
            }
        }
    }
}
