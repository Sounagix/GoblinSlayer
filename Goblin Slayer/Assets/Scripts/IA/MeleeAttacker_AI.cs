﻿using UnityEngine;

[RequireComponent(typeof(MeleeAttacker))]
public class MeleeAttacker_AI : MonoBehaviour, IAttacker_AI
{
    private MeleeAttacker attacker;


    private void Start()
    {
        attacker = GetComponent<MeleeAttacker>();
    }

    /// <inheritdoc />
    /// <summary>
    /// Attacks with a melee attack the <paramref name="target" />
    /// </summary>
    /// <param name="target">The receiver of the attack</param>
    public void Attack(Transform target)
    {
        attacker.MakeAttack((target.position - transform.position).normalized);
    }
}