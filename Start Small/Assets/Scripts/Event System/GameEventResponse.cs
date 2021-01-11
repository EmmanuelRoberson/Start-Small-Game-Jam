using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///This class acts as an delegate of responses to unity events
[System.Serializable]
public class GameEventResponse : UnityEngine.Events.UnityEvent<Object[]>
{

}
