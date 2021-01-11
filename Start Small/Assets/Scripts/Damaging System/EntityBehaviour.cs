using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (CompareTag("Player"))
        {
            transform.localScale *= 0.2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthRef.RuntimeValue <= 0)
        {
            Destroy(gameObject);
        }

        if (transform.localScale.magnitude >= 20)
        {
            SceneManager.LoadScene(2);
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
        damageOnScreenBehaviour.RecieveDamageUpdate(damageDealt, transform.position);

        transform.localScale *= 1.08f;
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
