using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///ISubscribeable is for objects that act as events
public interface ISubscribeable
{
    void AddListener(IListener listener);
    void RemoveListener(IListener listener);
    //"Invoke" the ISubscribeable with a parameter
    void Raise(Object obj);
    //"Invoke" the ISubscribeable
}
