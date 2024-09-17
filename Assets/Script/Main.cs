using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //set cap name,hp,suitcolor
    public CaptainAmerica CaptainAmerica;

    //set ironman name,hp,suitcolor
    public IronMan IronMan;
    void Start()
    {
        IronMan.Name = ("Bob");
        Debug.Log("*** Superheros fight!!!!");
        Debug.Log($"IronMan name: {IronMan.Name}, Hp: {IronMan.Hp}, Suit Color: {IronMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {CaptainAmerica.Name}, Hp: {CaptainAmerica.Hp}, Suit Color: {CaptainAmerica.SuitColor}");
        IronMan.UpdateArmor(5.25f);
        CaptainAmerica.UpdateArmor(5.5f);
    }
    private void Update()
    {
        //fight process
        if ( IronMan.IsDead() || CaptainAmerica.IsDead())
        {
            return;
        }
        IronMan.ShootLaser();
        //random damage ironman
        int randomvalue = Random.Range(10, 21);
        CaptainAmerica.TakeDamage(randomvalue);
        CaptainAmerica.ThrowShield();
        //random damage cap
        randomvalue = Random.Range(10, 21);
        IronMan.TakeDamage(randomvalue);
    }
}
