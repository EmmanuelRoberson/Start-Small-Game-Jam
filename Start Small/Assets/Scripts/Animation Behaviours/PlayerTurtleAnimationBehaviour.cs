using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurtleAnimationBehaviour : MonoBehaviour
{
    public Animator animator;

    public float animationSpeed;

    private int xDirectionHash;
    private int zDirectionHash;

    private int attack1Hash;
    private int defend1Hash;
    private int isPassiveHash;

    // Start is called before the first frame update
    void Start()
    {
        xDirectionHash = Animator.StringToHash("Dir X");
        zDirectionHash = Animator.StringToHash("Dir Z");

        attack1Hash = Animator.StringToHash("Attack1");
        defend1Hash = Animator.StringToHash("isDefending1");

        isPassiveHash = Animator.StringToHash("isPassive");
        

        animator.speed = animationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        animator.SetBool(isPassiveHash, true);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger(attack1Hash);
            animator.SetBool(isPassiveHash, false);
        }
        
        if (Input.GetMouseButton(1))
        {
            animator.SetBool(defend1Hash, true);
            animator.SetBool(isPassiveHash, false);
        }
        else
        {
            animator.SetBool(defend1Hash, false);
        }


        animator.SetFloat(xDirectionHash, xInput);
        animator.SetFloat(zDirectionHash, yInput);
    }
}
