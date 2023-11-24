using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 5;
    [SerializeField] private LayerMask _mask;


    public void Move(float x, float z)
    {
        Vector3 newVelocity = new Vector3(x, _rigidbody.velocity.y, z);
        _rigidbody.velocity = newVelocity.normalized * _speed;


    }

    private bool CanMove(Transform point ,Vector3 direction)
    {
        return (Physics.Raycast(point.position, direction, 0.25f, _mask)) == false;
    }
}
