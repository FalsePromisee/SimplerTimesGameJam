using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action OnGoodObjectCollected;
    public static Action OnBadObjectCollected;
    public static Action OnGoodObjectFellOnGround;

    public static void OnGoodObjectCollect()
    {
        OnBadObjectCollected?.Invoke();
    }
    public static void OnBadObjectCollect()
    {
        OnGoodObjectCollected?.Invoke();
    }
    public static void OnGoodObjectFallOnGround()
    {
        OnGoodObjectFellOnGround?.Invoke();
    }

}
