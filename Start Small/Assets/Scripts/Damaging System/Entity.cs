using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
    //health of the entity
    private float health;

    //damage of the entity
    private float damage;

    //initialized the entity's value
    public void Initialize(float hp, float dmg)
    {
        health = hp;
        damage = dmg;
    }

    //decreases the entitys health by the dmgTaken
    public void TakeDamage(float dmgTaken)
    {
        health -= dmgTaken;
    }

    //calls the TakeDamage method on reciever

    public void DoDamage(Entity reciever)
    {
        reciever.TakeDamage(damage);
    }

    public float Health { get { return health; } }
    public float Damage => damage;
}
