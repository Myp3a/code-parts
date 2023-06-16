using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : BaseEffect
{
    private int _heal;
    public HealEffect(int heal, int ticks)
    {
        _heal = heal;
        _ticks = ticks;
    }

    public override bool CanApplyToTarget(Char target)
    {
        if (target is IPlayerTarget || target is IEnemyTarget) { return true; } else { return false; }
    }

    public override void DoEffectAction(Char target)
    {
        if (_ticks <= 0) { return; }
        target.Health.Heal(_heal);
        _ticks--;
    }
}
