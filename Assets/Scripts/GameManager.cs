using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] Player player;

    public Player Player => player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        SetData();
    }

    public void SetData()
    {
        player = new Player("CodeSllave", "Kim", 30, 10, 100, 10, 2, 9, 10000);
    }
}
