using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class VampireCard : BaseCard
{
    private string _name = "Vampirism";
    private string _description;
    public override string Name { get => _name; set { } }
    public override string Description { get => _description; set { } }
    private int _heal;
    private int _damage;
    private IEffect _healEffect;
    private IEffect _damageEffect;
    [Inject] private Player _player;

    public VampireCard(int damage, int heal, int ticks)
    {
        _heal = heal;
        _damage = damage;
        _healEffect = new HealEffect(_heal, ticks);
        _damageEffect = new DamageEffect(_damage, ticks);
        _description = $"Do {_damage} damage to character.\nRestore {_heal} health to player.";
    }

    public override bool DoEffect(Char target)
    {
        ApplyEffectToTargets(_player, _healEffect);
        ApplyEffectToTargets(target, _damageEffect);
        return true;
    }
}