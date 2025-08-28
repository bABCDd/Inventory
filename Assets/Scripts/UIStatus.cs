using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI Attack;
    public TextMeshProUGUI Shield;
    public TextMeshProUGUI Health;
    public TextMeshProUGUI Critical;
    public UIMainMenu uiMainMenu;

    //여기도 생성자를 만들어야하나?
    void Start()
    {
        SetPlayerStatus(GameManager.instance.Player);
    }
    public void SetPlayerStatus(Player p)
    {
        GameManager.instance.SetData();
        Attack.text = $"{GameManager.instance.Player.AttackPower}";
        Shield.text = $"{GameManager.instance.Player.ShieldPower}";
        Health.text = $"{GameManager.instance.Player.Health}";
        Critical.text = $"{GameManager.instance.Player.CriticalChance}%";
    }
}
