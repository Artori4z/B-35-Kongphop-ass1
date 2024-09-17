using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //set cap name,hp,suitcolor
    CaptainAmerica captainAmerica = new CaptainAmerica("Steve", 100, "Gray");
    //set ironman name,hp,suitcolor
    IronMan ironMan = new IronMan("Tony", 100, "Red");
    void Start()
    {
        Debug.Log("*** Superheros fight!!!!");
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Suit Color: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Suit Color: {captainAmerica.SuitColor}");
        ironMan.UpdateArmor(5.25f);
        captainAmerica.UpdateArmor(5.25f);
    }
    private void Update()
    {
        //fight process
        if ( ironMan.IsDead() || captainAmerica.IsDead())
        {
            return;
        }
        ironMan.ShootLaser();
        //random damage ironman
        int randomvalue = Random.Range(10, 21);
        captainAmerica.TakeDamage(randomvalue);
        captainAmerica.ThrowShield();
        //random damage cap
        randomvalue = Random.Range(10, 21);
        ironMan.TakeDamage(randomvalue);
    }
}
