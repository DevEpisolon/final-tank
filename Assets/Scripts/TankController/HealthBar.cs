using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private HealthSystem healthSystem; 
    public void Setup(HealthSystem healthSystem){
        this.healthSystem = healthSystem;
        healthSystem.OnHealthChange +=  HealthSystem_OnHealthChange; 
    }
    private void HealthSystem_OnHealthChange(object sender, System.EventArgs e){
        transform.Find("Bar").localScale = new UnityEngine.Vector3(healthSystem.GetHealthPercentage(), 1);
    }

}
