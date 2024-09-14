using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica
{
    public string CapName;
    public int CapHp;
    public string CapSuitColor;
    private float capArmorStrength = 10f;

    public CaptainAmerica(string newName,int newHp,string newSuitColor) 
    {
        //set new name,hp,suitcolor
        CapName = newName;
        CapHp = newHp;
        CapSuitColor = newSuitColor;
    }
    public void LeapAndJump()
    {
        Debug.Log($"--------{CapName} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={CapName} is Trowing Shield!!!");

    }
    public void TakeDamage(int damage)
    {
        CapHp -= damage;
        Debug.Log($"{CapName} take {damage} damage hp: {CapHp}");
    }
}
