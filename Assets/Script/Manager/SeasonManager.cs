using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Season { spring = 0, summer, fall, winter };

public class SeasonManager : MonoBehaviour
{

    public static SeasonManager instance { get; private set; }
    public Season nowSeason;

    [Tooltip("작물 자라나는 속도")]
    public float plusGrowSpeed;
    [Tooltip("계절에 따라 +- @ 작물지급")]
    public float plusCrop;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        nowSeason = Season.spring;
    }
    private void Update()
    {

    }
    public void ChangeState()
    {
        if (nowSeason == Season.winter)
        {
            nowSeason = Season.spring;
            return;
        }
        nowSeason++;
    }
}
