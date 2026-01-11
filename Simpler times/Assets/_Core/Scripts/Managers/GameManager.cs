using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool IsSecondStage = true;
    
    
    private void Awake()
    {
        Instance = this;
    }
}
