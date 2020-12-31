using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Interface for an object that listens for events and responds when the event it listens for is raised
///Sort of acts as a middle man between methods and events
public interface IListener
{
    void Subscribe();
    void Unsubscribe();
    
    //OnEventRaised is called when the event is raised, with parameters
    void OnEventRaised(params Object[] obj);
    //OnEventRaised is called when the event is raised, without parameters
    void OnEventRaised();
    
}
