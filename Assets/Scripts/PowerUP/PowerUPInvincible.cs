using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPInvincible : PowerUPBase
{
    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.SetPowerUPText("Invincible");
        PlayerController.Instance.SetInvincible();
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.SetPowerUPText("");
        PlayerController.Instance.SetInvincible(false);
    }
}
