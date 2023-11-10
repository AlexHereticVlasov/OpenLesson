using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed = 5;
    [SerializeField] private LayerMask _mask;


    public void Move(Vector3 direction, int first, int second)
    {
        if (IsObsticle(_points[first], direction) || IsObsticle(_points[second], direction))
        {
            transform.Translate(direction * Time.deltaTime * _speed);
        }

    }

    private bool IsObsticle(Transform point ,Vector3 direction)
    {
        return (Physics.Raycast(transform.position, direction, 0.5f, _mask)) == false;
    }
}
