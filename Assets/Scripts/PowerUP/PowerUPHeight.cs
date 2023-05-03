using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPHeight : PowerUPBase
{
    [Header("Power UP Height")]
    public float amountToHeight = 2;

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.ChangeHeight(amountToHeight, duration);
    }
}
