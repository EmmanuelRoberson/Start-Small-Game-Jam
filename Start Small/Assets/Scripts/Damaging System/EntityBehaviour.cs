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
        if (selfEntity.Health >= 0)
        {
            selfEntity.OnDie.Invoke();
        }
    }

    public void TakeDamage(float damageTaken)
    {
        selfEntity.TakeDamage(damageTaken);
    }

    //Event to be called from the animator, this controls how much damage is done
    public void CanDamage(float val)
    {
        damageRef.RuntimeValue = val + selfEntity.Damage;
    }

    void OnTriggerEnter(Collider other)
    {
        EntityBehaviour otherEntity = other.gameObject.GetComponent<EntityBehaviour>();
        if (otherEntity != null)
        {
            otherEntity.TakeDamage(damageRef.RuntimeValue);
        }
    }

}
