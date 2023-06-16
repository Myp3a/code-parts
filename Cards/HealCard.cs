using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCard : BaseCard
{
    private string _name = "Heal";
    private string _description;
    public override string Name { get => _name; set { } }
    public override string Description { get => _description; set { } }
    private int _heal;
    private IEffect _effect;
    public HealCard(int heal, int ticks)
    {
        _heal = heal;
        _effect = new HealEffect(_heal, ticks);
        _description = $"Restore {_heal} health to character.";
    }

    public override bool DoEffect(Char target)
    {
        ApplyEffectToTargets(target, _effect);
        return true;
    }
}