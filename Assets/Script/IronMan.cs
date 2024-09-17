using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public void Fly()
    {
        Debug.Log($"--------{name} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{name} is Shooting Lasers!");
    }
   
}
