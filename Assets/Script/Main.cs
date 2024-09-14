using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Debug.Log("*** Superheros fight!!!!");
        //set cap name,hp,suitcolor
        CaptainAmerica captainAmerica = new CaptainAmerica("Steve", 100, "Gray");
        //set ironman name,hp,suitcolor
        IronMan ironMan = new IronMan("Tony", 100 ,"Red");
        Debug.Log($"IronMan name: {ironMan.IronName}, Hp: {ironMan.IronHp}, Suit Color: {ironMan.IronSuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.CapName}, Hp: {captainAmerica.CapHp}, Suit Color: {captainAmerica.CapSuitColor}");
        //fight process
        for ( int i = 0; i<5; i++)
        {
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
}
