using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PoolManager pool;
    public Player player;

    public float gameTime;  //게임 시간 변수
    public float maxGameTime = 2 * 10f; //최대 게임 시간 변수(20초).

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }
}
