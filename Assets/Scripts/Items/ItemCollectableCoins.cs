using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoins : CollectableBase
{
    public static ItemCollectableCoins Instance;
    int score;
    public Collider2D collider;

    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
        collider.enabled = false;
    }

}
