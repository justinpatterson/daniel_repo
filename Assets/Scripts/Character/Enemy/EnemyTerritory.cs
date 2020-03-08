using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTerritory : MonoBehaviour
{
    public BoxCollider territory;
    bool _playerInTerritory; 

    public GameObject enemy; 
    BasicEnemy _basicenemy; 

    // Start is called before the first frame update
    void Start()
    {
        _basicenemy = enemy.GetComponent <BasicEnemy> (); 
        _playerInTerritory = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (_playerInTerritory == true)
        {
           _basicenemy.MoveToPlayer ();
        }
        
        if (_playerInTerritory == false)
        {
           //basicenemy.Rest ();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerInTerritory = true;
            Debug.Log("PLAYER IN TERRITORY");
        }
    }
    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerInTerritory = false;
            Debug.Log("PLAYER NOT IN TERRITORY");
        }
    }
}
