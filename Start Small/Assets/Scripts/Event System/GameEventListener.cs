using UnityEngine;


public class GameEventListener : MonoBehaviour, IListener
{
    [TextArea] public string Notes;

    public GameEvent GameEvent;
    public GameEventResponse Response;


    public GameObject SenderObject;

    public void OnEnable()
    {
        Subscribe();
    }

    public void OnDisable()
    {
        Unsubscribe();
    }


    public void OnEventRaised(params Object[] arguments)
    {
        var sender = arguments[0];
        var other = arguments[1];

        //if its null, or the sender is the SenderObject, call it
        if (SenderObject == null)
        {
            Response.Invoke(arguments);
        }
        else
        {
            if (SenderObject == sender)
            {
                Response.Invoke(arguments);
            }
        }
    }

    public void OnEventRaised()
    {
        OnEventRaised(null);
    }

    public void Subscribe()
    {
        GameEvent.AddListener(this);
    }

    public void Unsubscribe()
    {
        GameEvent.RemoveListener(this);
    }


}
