using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) : base(newName, newHp, newSuitColor)
    {
    }

    public void Fly()
    {
        Debug.Log($"--------{Name} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{Name} is Shooting Lasers!");
    }
   
}
