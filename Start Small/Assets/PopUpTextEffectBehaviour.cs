using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpTextEffectBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoHopAndFade(float fallRate)
    {
        StartCoroutine(HopAndFade(fallRate));
    }

    public IEnumerator HopAndFade(float fallRate)
    {
        TMP_Text text = GetComponent<TMP_Text>(); 

        float countdown = 1.5f;

        float fadeRate = 2f;

        float gravity = fallRate;

        Vector3 velocity = new Vector3(5f, 10f, -3f);

        Object.Destroy(this.gameObject, countdown);

        Vector3 currentVelocity;

        while (countdown >= 0f)
        {
            velocity.y -= gravity * Time.deltaTime;

            transform.position += velocity * Time.deltaTime;

            yield return 0;
        }
    }
}
