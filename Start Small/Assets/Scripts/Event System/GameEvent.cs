using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : ScriptableObject, ISubscribeable
{
    //List of all the IListeners that respond when the GameEvent is raised 
    private List<IListener> listeners = new List<IListener>();
    public void AddListener(IListener listener)
    {
        throw new System.NotImplementedException();
    }

    public void Raise(Object obj)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveListener(IListener listener)
    {
        throw new System.NotImplementedException();
    }
}
