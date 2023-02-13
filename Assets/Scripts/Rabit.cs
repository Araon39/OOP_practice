using UnityEngine;
using TMPro;

public class Rabit : AnimalBase
{
    [SerializeField] private float _jumpRabit;
    [SerializeField] private Rigidbody _rbRabit;

    private void Start()
    {
        AgeAnimal = 1;
        HeightAnimal = 0.5f;
        NameAnimal = "Rabit";
        Init(_jumpRabit, _rbRabit);
        // Init(jumpForce: _jumpRabit, rb: _rbRabit);
        // Init(rb: _rbRabit, jumpForce: _jumpRabit);
        //Vector3 vec = new Vector3(x: 0, y: 1, z: 2);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
}