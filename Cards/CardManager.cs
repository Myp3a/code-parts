using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager
{
    private List<BaseCard> _cardList;
    private List<BaseCard> _availableCards = new List<BaseCard>();

    public CardManager()
    {
        _cardList = new List<BaseCard> {
            new DamageCard(5,1),
            new DamageCard(7,1),
            new HealCard(3,1),
            new VampireCard(4,2,1),
            new DamageCard(6,1),
            new DamageCard(10,1),
            new HealCard(1,1)
        };
        _availableCards = _cardList;
    }

    public BaseCard GetRandomAvailableCard()
    {
        if (_availableCards.Count == 0)
        {
            return null;
        }
        BaseCard _card = _availableCards[Random.Range(0, _availableCards.Count)];
        _availableCards.Remove(_card);
        return _card;
    }
}
