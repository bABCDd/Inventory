using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int AttackPower;
    public int ShieldPower;
    public int Health;
    public int CriticalChance;

    public Player(int attackPower, int shieldPower, int health, int criticalChance)
    {
        AttackPower = attackPower;
        ShieldPower = shieldPower;
        Health = health;
        CriticalChance = criticalChance;
    }
}
