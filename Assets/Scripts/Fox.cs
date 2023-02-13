using TMPro;
using UnityEngine;

public class Fox : AnimalBase
{
    [SerializeField] private float _jumpFox;
    [SerializeField] private Rigidbody _rbFox;

    private void Start()
    {
        AgeAnimal = 7;
        HeightAnimal = 5f;
        NameAnimal = "Fox";
        
        Init(_jumpFox, _rbFox);
        SetColor(new Color(1f, 0.61f, 0.28f));
        //_text.text = AgeAnimal + " " + NameAnimal + " " + HeightAnimal;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Jump();
        }
    }
}