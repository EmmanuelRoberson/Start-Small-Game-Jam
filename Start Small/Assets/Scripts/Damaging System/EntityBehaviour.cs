using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBehaviour : MonoBehaviour
{
    public FloatVar healthRef;
    public FloatVar damageRef;

    public LayerMask entityMask;

    private bool canDamage;

    private Entity selfEntity = new Entity();

    public DetachedTriggerBehaviour damageTrigger;

    public DamageOnScreenBehaviour damageOnScreenBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        healthRef.Instantiate();    
        damageRef.Instantiate();

        selfEntity.Initialize(healthRef.RuntimeValue, damageRef.RuntimeValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthRef.RuntimeValue <= 0)
        {
            Destroy(gameObject);
        }
    }

    public float TakeDamage(float damageTaken)
    {
        healthRef.RuntimeValue -= damageTaken;
        return damageTaken;
    }

    public void DoDamage(EntityBehaviour otherEntity)
    {
        float damageDealt = otherEntity.TakeDamage(damageRef.RuntimeValue);
        damageOnScreenBehaviour.RecieveDamageUpdate(damageDealt);
    }

    //Events to be called from the animator, this controls how much damage is done /////////////////////////
    public void CanDamage(float val)
    {
        damageRef.RuntimeValue = val + damageRef.value;
    }

    public void EnableDamageCollider(int intToBool)
    {
        damageTrigger.EnableCollider(intToBool);
    }
}
