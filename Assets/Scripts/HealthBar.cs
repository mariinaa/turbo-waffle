using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void setMaxHealth (float fullHP, float startingHP)
    {
        slider.maxValue = fullHP;
        slider.value = startingHP;
        fill.color = gradient.Evaluate(startingHP);

    }
    public void setHealth(float currentHP)
    {
        slider.value = currentHP;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
   
}
