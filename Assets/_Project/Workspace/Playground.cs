using System;
using UnityEngine;

public class Playground : MonoBehaviour
{
    public OpenCloseTweenBase[] animations;

    private void Open()
    {
        foreach (var anim in animations)
        {
            anim.Open();
        }
    }
    
    private void Close()
    {
        foreach (var anim in animations)
        {
            anim.Close();
        }
    }

    // Enemy
    private void Attack()
    {
        float damage = CalculateDamage(5);
    }

    // Player
    private float CalculateDamage(int rawDamage)
    {
        float armor = 10;
        return Mathf.Max(0, rawDamage - armor);
        Debug.Log("Hey");
    }
}