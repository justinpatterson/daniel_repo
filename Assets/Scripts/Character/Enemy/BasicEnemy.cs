using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float attack1Range = 1f; 
    public int attack1Damage = 1;
    public float timeBetweenAttacks;

    public float attackCooldown = 0f;
    
    public void MoveToPlayer ()
    {
        //rotate to look at player
        Vector3 nextTargetPosition = target.position;
        nextTargetPosition.y = transform.position.y;
        transform.LookAt (nextTargetPosition);
        transform.Rotate (new Vector3 (0, -90, 0), Space.Self); 
        Debug.Log("MOVE TO DA PLAYER");
        //move towards player 
        if (Vector3.Distance(transform.position, target.position) > attack1Range)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        else
        {
            if (attackCooldown <= 0)
            {
                //KILL THE PLAYER
                attackCooldown = 1f;
                if (target.GetComponent<CharacterStats>())
                {
                    target.GetComponent<CharacterStats>().DamageCharacter(1f);
                }
            }
            else
            {
                //WAIT UNTIL IT IS TIME TO STRIKE
                attackCooldown = attackCooldown - Time.deltaTime;
            }
        }
        
    }
}
