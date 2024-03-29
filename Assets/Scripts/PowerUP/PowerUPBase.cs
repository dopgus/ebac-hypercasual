using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPBase : CollectableBase
{
    public float duration;

    protected override void OnCollect()
    {
        base.OnCollect();
        StartPowerUp();
    }
    protected virtual void StartPowerUp()
    {
        Debug.Log("Start Power UP");
        Invoke(nameof(EndPowerUp), duration);
    }

    protected virtual void EndPowerUp()
    {
        Debug.Log("End Power UP");
    }
}
