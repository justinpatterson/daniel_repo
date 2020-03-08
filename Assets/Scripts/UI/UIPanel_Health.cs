using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Health : MonoBehaviour
{
    public CharacterStats character_target;
    public Image health_meter_foreground;

    private void LateUpdate()
    {
        health_meter_foreground.transform.localScale =
            new Vector3( character_target.GetHealthPercentage() ,1,1);
    }
}
