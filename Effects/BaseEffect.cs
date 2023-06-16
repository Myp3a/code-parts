using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

// TODO: do we need an effect interface?
public class BaseEffect : IEffect
{
    protected readonly SignalBus _signalBus;
    protected Char _target;
    protected int _ticks;

    public int GetTicks() => _ticks;
    public bool TryApplyToTarget(Char target)
    {
        bool canApply = CanApplyToTarget(target);
        if (canApply)
        {
            _target = target;
            target.AddEffect(this);
        }
        return canApply;
    }

    public virtual bool CanApplyToTarget(Char target)
    {
        throw new NotImplementedException();
    }

    public virtual void DoEffectAction(Char target)
    {
        throw new NotImplementedException();
    }


}
