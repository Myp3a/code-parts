using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TODO: does this must be an abstract class?
public abstract class BaseCard
{
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    // TODO: check if effect can be applied
    public virtual bool DoEffect(Char target)
    {
        throw new NotImplementedException(); 
    }
    protected void ApplyEffectToTargets(List<Char> targets, IEffect effect)
    {
        foreach (Char target in targets)
        {
            ApplyEffectToTargets(target, effect);
        }
    }

    protected void ApplyEffectToTargets(Char target, IEffect effect)
    {
        target.AddEffect(effect);
    }
}
