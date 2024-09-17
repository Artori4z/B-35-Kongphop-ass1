using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    //Attributes
    protected string name;
    public string Name{get{ return name;}set{name = value;}}
    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }
    public string SuitColor { get; set; }
    private float armorStrength;
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        //set new name,hp,suitcolor
        name = newName;
        hp = newHp;
        SuitColor = newSuitColor;
    }
    public void UpdateArmor(float strength)
    {
        armorStrength += strength;
        Debug.Log($"{name} undateed their armor to {armorStrength}");
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{name} take {damage} damage hp: {hp}");
    }
    public bool IsDead()
    {
     return hp <= 0;
    }
}
