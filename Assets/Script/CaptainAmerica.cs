using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"--------{_name} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={_name} is Trowing Shield!!!");

    }
    public override void Move()
    {
       LeapAndJump();
    }
    public override void Attack()
    {
        ThrowShield();
    }

   
}