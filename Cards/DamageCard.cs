using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCard : BaseCard
{
    private string _name = "Damage";
    private string _description;
    public override string Name { get => _name; set { } }
    public override string Description { get => _description; set { } }
    private int _damage;
    private IEffect _effect;
    public DamageCard(int damage, int ticks)
    {
        _damage = damage;
        _effect = new DamageEffect(_damage, ticks);
        _description = $"Do {_damage} damage to character.";
    }

    public override bool DoEffect(Char target)
    {
        ApplyEffectToTargets(target, _effect);
        return true;
    }
}