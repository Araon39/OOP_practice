using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    private float _jumpForce;
    private Rigidbody _rb;

    protected void Init(float jumpForce, Rigidbody rb)
    {
        _jumpForce = jumpForce;
        _rb = rb;
    }

    protected void Jump()
    {
        _rb.AddForce(Vector3.up * _jumpForce);
    }
}