using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachedTriggerBehaviour : MonoBehaviour
{
    public EntityBehaviour entityBehaviour; 

    public float triggerCooldown;
    private float triggerCooldownTimer;
    private BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();

        triggerCooldownTimer = triggerCooldown;
    }

    public void EnableCollider(int intToBool)
    {
        boxCollider.enabled = (intToBool != 0);
    }

    public void Update()
    {
        triggerCooldownTimer -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            return;
        }

        if (triggerCooldownTimer <= 0)
        {
            EntityBehaviour otherEntity = other.gameObject.GetComponent<EntityBehaviour>();
            if (otherEntity != null)
            {
                entityBehaviour.DoDamage(otherEntity);

                triggerCooldownTimer = triggerCooldown;
            }
        }
    }
}
