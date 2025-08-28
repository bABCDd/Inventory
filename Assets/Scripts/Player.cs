using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string ID { get; private set; }
    public string Name { get; private set; }
    public int AttackPower { get; private set; }
    public int ShieldPower { get; private set; }
    public int Health { get; private set; }
    public int CriticalChance { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public int Gold { get; private set; }


    public Player(string id, string Name, int attackPower, int shieldPower, int health, int criticalChance, int lv, int Exp, int gold)
    {
        ID = id;
        this.Name = Name;
        AttackPower = attackPower;
        ShieldPower = shieldPower;
        Health = health;
        CriticalChance = criticalChance;
        Level = lv;
        Experience = Exp;
        Gold = gold;
    }
}
