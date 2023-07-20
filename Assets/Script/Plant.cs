using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plant : MonoBehaviour
{

    [Header("--- >> Crop << ----")]
    [Tooltip("작물 리소스")]
    List<Sprite> plant = new List<Sprite>();
    [Tooltip("작물 성장치")]
    public int[] cropLevel;
    public float nowCropLevel;
    [Tooltip("작물 자라나는 속도")]
    public float gropSpeed;
    [Tooltip("수확량")]
    public int getCrop;
    [Tooltip("판매가격")]
    public int cropPrice;
    // --- > 작물 성장 리소스 테스트 --- < 
    public Color[] color = {Color.red, Color.blue, Color.green};

    int arrayNum = 0;

    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        nowCropLevel += Time.deltaTime * gropSpeed;
        if(nowCropLevel >= cropLevel[arrayNum])
        {
            sprite.color = color[arrayNum];
            arrayNum++;
            nowCropLevel = 0;
        }
    }
    
}