using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPHeight : PowerUPBase
{
    [Header("Power UP Height")]
    public float amountToHeight = 2;
    public float animationDuration = .1f;
    public DG.Tweening.Ease ease = DG.Tweening.Ease.OutBack;

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.ChangeHeight(amountToHeight, duration, animationDuration, ease);
    }
}
