using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPSpeedUp : PowerUPBase
{
    [Header("Power UP Speed Up")]
    public float amountToSpeed;

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.PowerUPSpeedUp(amountToSpeed);
        PlayerController.Instance.SetPowerUPText("Speed up");
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.SetPowerUPText("");
        PlayerController.Instance.ResetSpeed();
    }
}
