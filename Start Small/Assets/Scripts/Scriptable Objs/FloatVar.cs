using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/FloatVar")]
public class FloatVar : ScriptableObject
{
    public float value;
    private float runtimeValue;

    public void Instantiate()
    {
        runtimeValue = value;
    }

    public float RuntimeValue 
    {
        get => runtimeValue;
        set => runtimeValue = value;
    } 

    public float Value{ get { return value; } }
}
