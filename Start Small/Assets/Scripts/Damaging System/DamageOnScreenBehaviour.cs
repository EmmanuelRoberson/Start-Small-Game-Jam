using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageOnScreenBehaviour : MonoBehaviour
{
    public TMP_Text accumulatedDamageText;
    public TMP_Text instantDamageText;
    public float textLifetime;

    public float disappearSpeed;

    public float size;

    private float lifetimeCountdown;

    private float damageAccumulated;

    private float instantDamage;
    // Start is called before the first frame update
    void Start()
    {
        lifetimeCountdown = 0;
        damageAccumulated = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //update text
        accumulatedDamageText.text = damageAccumulated.ToString();

        instantDamageText.text = instantDamage.ToString();

        if (lifetimeCountdown <= 0)
        {
            accumulatedDamageText.fontSize = 0;
            instantDamageText.fontSize = 0;
        } 

        if (lifetimeCountdown >= 0)
        {
            accumulatedDamageText.fontSize = size;
            instantDamageText.fontSize = size;

             //decrease lifetime
            lifetimeCountdown -= Time.deltaTime;
        }
    }

    public void RecieveDamageUpdate(float damage)
    {
        if (lifetimeCountdown <= 0 )
        {
            damageAccumulated = damage;
        }

        accumulatedDamageText.fontSize = size;
        instantDamageText.fontSize = size;

        damageAccumulated += damage;
        instantDamage = damage;
        lifetimeCountdown = textLifetime;
    }
}
