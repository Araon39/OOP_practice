using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Fox : AnimalBase
{
    [SerializeField] private float _jumpFox;
    [SerializeField] private Rigidbody _rbFox;
    private void Start()
    {
        Init(_jumpFox, _rbFox);
        SetColor(Color.red);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Jump();
        }
        
    }
}