using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIms : MonoBehaviour
{
    [SerializeField] private string mask;
    private float _timelast;
    private TMP_Text _tmpText;

    private void Awake()
    {
        _tmpText = GetComponent<TMP_Text>();
    }
    
    public void OnClick()
    {
        _tmpText.text = String.Format(mask, (Time.unscaledTime - _timelast).ToString("R"));
        _timelast = Time.unscaledTime;
    }
}
