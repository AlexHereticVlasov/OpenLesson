using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;

    private void Update()
    {
        transform.Rotate(Vector3.forward, 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerMovement player))
        {
            //ToDO: Collect coin
            var effect = Instantiate(_particle, transform.position, transform.rotation);
            Destroy(effect, 5);
            Destroy(gameObject);
        }
    }
}
