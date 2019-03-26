﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Projectile projectile;
    private Mana mana;
    public float manaCost = 20.0f;


    private void Start()
    {
        mana = GetComponent<Mana>();
    }
    /// <summary>
    /// Crea el proyectil en la posición del padre
    /// </summary>
    private Projectile CreateProjectile()
    {
        return Instantiate(projectile, transform.position, Quaternion.identity, gameObject.transform);
    }


    /// <summary>
    /// Shoots a <seealso cref="Projectile"/> in the given direction
    /// </summary>
    /// <param name="direction">The direction in wich the proyectile should shooted</param>
    public void Shoot(Vector2 direction)
    {
        if(mana.UseMana(manaCost))
        {
            Projectile p = CreateProjectile();
            p.SetDirection(direction);
            p.ShootYourSelf();
            Debug.DrawLine(transform.position, direction, Color.red);
        }
        else
        {
            print("not enough mana");
        }

    }

    public LayerMask SetCollisionMask()
    {
        return GetComponent<LayerMask>();//???
    }

}