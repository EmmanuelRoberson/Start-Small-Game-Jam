using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvents/GameEvent")]
public class GameEvent : ScriptableObject, ISubscribeable
{
    //List of all the IListeners that respond when the GameEvent is raised 
    private List<IListener> listeners = new List<IListener>();
    public void AddListener(IListener listener)
    {
        listeners.Add(listener);
    }

    public void Raise(Object obj)
    {
        Raise(obj);
    }

    public void Raise()
    {
        Raise(new Object());
    }

    public void RemoveListener(IListener listener)
    {
        listeners.Remove(listener);
    }
}
