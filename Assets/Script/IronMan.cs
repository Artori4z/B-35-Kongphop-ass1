using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public void Fly()
    {
        Debug.Log($"--------{_name} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{_name} is Shooting Lasers!");
    }
    public override void Move()
    {
        Fly();
    }
    public override void Attack()
    {
        ShootLaser();
    }
   
}
