using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventListener : MonoBehaviour, IListener
{
    [TextArea] public string Notes;


    public void OnEventRaised(params Object[] obj)
    {
        throw new System.NotImplementedException();
    }

    public void OnEventRaised()
    {
        throw new System.NotImplementedException();
    }

    public void Subscribe()
    {
        throw new System.NotImplementedException();
    }

    public void Unsubscribe()
    {
        throw new System.NotImplementedException();
    }
}
