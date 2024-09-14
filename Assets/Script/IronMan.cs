using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan
{
    public string IronName;
    public int IronHp;
    public string IronSuitColor;
    private float armorStrength = 10f;

    public IronMan(string newName, int newHp, string newSuitColor)
    {
        //set new name,hp,suitcolor
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
