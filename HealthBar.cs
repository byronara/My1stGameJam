using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Slider;

    public void SetMaxHP(int maxHP)
    {
        Slider.maxValue = maxHP;
        Slider.value = maxHP;
    }

    public void SetHP(int currentHP)
    {
        Slider.value = currentHP;
    }
}
