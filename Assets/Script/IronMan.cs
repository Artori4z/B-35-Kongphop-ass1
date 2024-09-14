using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan
{
    //name hp sc as flyvoid shootlaservoid isdeadbool takedamageintvoid
    public string IronName;
    public int IronHp;
    public string IronSuitColor;
    private float armorStrength = 10f;

    public IronMan(string newName, int newHp, string newSuitColor)
    {
        IronName = newName;
        IronHp = newHp;
        IronSuitColor = newSuitColor;
    }
    public void Fly()
    {
        Debug.Log($"--------{IronName} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{IronName} is Shooting Lasers!");
    }
    public void UpdateStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($"{IronName} undateed their armor to {armorStrength}");
    }
    public void TakeDamage(int damage)
    {
        IronHp -= damage;
        Debug.Log($"{IronName} take {damage} damage hp: {IronHp}");
    }
}
