using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float currentHealth = 0;
    private float _maxHealth = 10f;

    private void Awake()
    {
        currentHealth = _maxHealth;
    }

    public void DamageCharacter(float amount)
    {
        currentHealth = currentHealth - amount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, _maxHealth);
        Debug.Log("Character got damaged and now has " + currentHealth + "remaining");
    }

    public float GetHealthPercentage()
    {
        Debug.Log("Character percentage health is " + (currentHealth / _maxHealth));
        return Mathf.Clamp((currentHealth / _maxHealth), 0f, 1f); 
    }
}
