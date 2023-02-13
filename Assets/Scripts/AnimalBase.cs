using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    private float _jumpForce;
    private Rigidbody _rb;

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
}