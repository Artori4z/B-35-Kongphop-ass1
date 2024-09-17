using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    //Attributes
    protected string _name;
    public string Name{get{ return name;}set{name = value;}}
    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }
    public string SuitColor { get; set; }
    private float armorStrength;
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
