using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}

    public int Money;
     
    void Awake()
    {
        instance = this;
    }

}
