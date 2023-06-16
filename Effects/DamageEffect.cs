using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : BaseEffect
{
    private int _damage;

    public DamageEffect(int damage, int ticks)
    {
        _damage = damage;
        _ticks = ticks;
    }

    public override bool CanApplyToTarget(Char target)
    {
        if (target is IPlayerTarget || target is IEnemyTarget) { return true; } else { return false; }
    }

    public override void DoEffectAction(Char target)
    {
        if (_ticks <= 0) { return; }
        target.Health.Damage(_damage);
        _ticks--;
    }
}
