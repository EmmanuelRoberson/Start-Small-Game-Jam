using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpTextEffectBehaviour : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoHopAndFade(float textToDisplay,float fallRate)
    {
        text.text = textToDisplay.ToString();
        StartCoroutine(HopAndFade(fallRate));
    }

    public IEnumerator HopAndFade(float fallRate)
    {
        
        float countdown = 1.5f;

        float fadeRate = 2f;

        float gravity = fallRate;

        Vector3 velocity = new Vector3(5f, 10f, -3f);

        Object.Destroy(this.gameObject, countdown);

        while (countdown >= 0f)
        {
            velocity.y -= gravity * Time.deltaTime;

            transform.position += velocity * Time.deltaTime;

            text.alpha -= fadeRate * Time.deltaTime;

            yield return 0;
        }
    }
}
