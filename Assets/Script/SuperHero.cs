using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    //Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength ;

    //ont
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        //set new name,hp,suitcolor
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
    }
    public void UpdateArmor(float strength)
    {
        armorStrength += strength;
        Debug.Log($"{Name} undateed their armor to {armorStrength}");
    }
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log($"{Name} take {damage} damage hp: {Hp}");
    }
    public bool IsDead()
    {
     return Hp <= 0;
    }
}
