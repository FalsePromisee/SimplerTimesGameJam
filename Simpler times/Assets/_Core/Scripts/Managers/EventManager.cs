using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action<int> OnGoodObjectCollected;
    public static Action<int> OnBadObjectCollected;
    public static Action OnGoodObjectFellOnGround;

    public static void OnGoodObjectCollect(int amount)
    {
        OnGoodObjectCollected?.Invoke(amount);
    }
    public static void OnBadObjectCollect(int amount)
    {
        OnBadObjectCollected?.Invoke(amount);
    }
    public static void OnGoodObjectFallOnGround()
    {
        OnGoodObjectFellOnGround?.Invoke();
    }

}
