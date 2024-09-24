using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperHero : MonoBehaviour
{
    //Attributes
    protected string _name;
    public string Name{get{ return _name;}set{_name = value;}}
    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }
    protected string suitColor;
    public string SuitColor { get { return suitColor; } set { suitColor = value; } }
    protected float armorStrength;
    public void UpdateArmor(float strength)
    {
        armorStrength += strength;
        Debug.Log($"{_name} undateed their armor to {armorStrength}");
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{_name} take {damage} damage hp: {hp}");
    }
    public bool IsDead()
    {
     return hp <= 0;
    }
    public abstract void Move();
    public abstract void Attack();
    
}
