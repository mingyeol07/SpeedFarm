using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance { get; private set; }
    
    [SerializeField] private Text timeText;
    [Tooltip("시간 설정")] public float time;
    [Tooltip("시간 설정")] public float maxTime;

    public bool isTimeEnd = false;

    GameManager gameMgr;

    void Awake()
    {
        instance = this;
        gameMgr = GameManager.instance;
    }
    void Start()
    {
        timeText.text = "" + time;
    }
    void Update()
    {
        TimeMgr();
    }

    void TimeMgr()
    {
        //  계절마다 시간
        if (time <= 0)
        {
            SeasonManager.instance.ChangeState();
            time = maxTime;
            return;
        }
        // 돈이 없으면 파산을 해 게임종료
        else if(gameMgr.Money == 0)
        {
            Debug.Log("게임종료");
            return;
        }
        
        time -= Time.deltaTime;
        timeText.text = "" + Mathf.Round(time);
    }
}

