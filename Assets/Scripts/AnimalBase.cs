using TMPro;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    //создаем переменые:
    [SerializeField] private TMP_Text _text;

    private int _ageAnimal;         //возраст животного
    private float _heightAnimal;
    private float _jumpForce;

    private string _nameAnimal;
    private Rigidbody _rb;

    protected int AgeAnimal
    {
        get => _ageAnimal;
        set
        {
            _ageAnimal = value;
            _text.text = $"Возраст {AgeAnimal}\nИмя {NameAnimal}\nВысота {HeightAnimal}";
        }
    }

    protected string NameAnimal
    {
        get => _nameAnimal;
        set
        {
            _nameAnimal = value;
            _text.text = $"Возраст {AgeAnimal}\nИмя {NameAnimal}\nВысота {HeightAnimal}";
        }
    }

    protected float HeightAnimal
    {
        get => _heightAnimal;
        set
        {
            _heightAnimal = value;
            _text.text = $"Возраст {AgeAnimal}\nИмя {NameAnimal}\nВысота {HeightAnimal}";
        }
    }

    // protected - модификатор доступа. К нему имеют доступ потомки класса
    // float jumpForce, Rigidbody rb - параметры фукнции (метода)
    // void - функция (метод) ничего не возвращает
    protected void Init(float jumpForce, Rigidbody rb)
    {
        _jumpForce = jumpForce;
        _rb = rb;
    }

    protected void Jump()
    {
        print("Jump!");
        _rb.AddForce(Vector3.up * _jumpForce);
    }

    protected void SetColor(Color color) //принимаем цвет типа цвет от наших потомков
    {
        Material material = GetComponent<Renderer>().material;
        material.color = color;
    }
}