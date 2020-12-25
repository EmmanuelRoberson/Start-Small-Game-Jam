using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public FloatVar Health;

    public Camera camToLookAt;

    void Start()
    {
        slider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Health.RuntimeValue/Health.Value;

        if (Health.RuntimeValue <= Health.Value)
        {
            slider.enabled = true;
        }

        transform.LookAt(camToLookAt.transform);
    }
}
