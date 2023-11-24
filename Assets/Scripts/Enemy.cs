using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out PlayerMovement player))
        {
            Destroy(player.gameObject);
        }
    }
}

public sealed class Test : MonoBehaviour
{
    [SerializeField] float _value;

    private void Update()
    {
        _value = GetComponent<Transform>().position.x;
        Debug.Log($"{_value}");
    }
}
