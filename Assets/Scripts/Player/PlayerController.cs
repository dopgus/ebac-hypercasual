using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using TMPro;

public class PlayerController : Singleton<PlayerController>
{
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 1f;

    public float speed = 1f;

    public string tagToCheckEnemy = "Enemy";
    public string tagToCheckEndLine= "EndLine";

    public GameObject endScreen;

    [Header("Text")]
    public TextMeshPro uiTextPowerUP;

    private bool _canRun;
    private Vector3 _pos;
    private float _currentSpeed;

    public bool invincible = true;
    private void Start()
    {
        ResetSpeed();
    }

    void Update()
    {
        if (!_canRun) return;

        _pos = target.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
        transform.Translate(transform.forward * _currentSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagToCheckEnemy)
        {
            if(!invincible) EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == tagToCheckEndLine)
        {
            if (!invincible) EndGame();
        }
    }

    private void EndGame()
    {
        _canRun = false;
        endScreen.SetActive(true);
    }

    public void StartToRun()
    {
        _canRun = true;
    }

    #region POWERUPS
    public void SetPowerUPText(string s)
    {
        uiTextPowerUP.text = s;
    }

    public void PowerUPSpeedUp(float f)
    {
        _currentSpeed = f;
    }

    public void SetInvincible(bool b = true)
    {
        invincible = b;
    }

    public void ResetSpeed()
    {
        _currentSpeed = speed;
    }

    public void ChangeHeight(float amount, float duration)
    {
        var p = transform.position;
        p.y = amount;
        transform.position = p;
    }
    #endregion
}
