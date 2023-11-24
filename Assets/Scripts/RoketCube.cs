using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RoketCube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    int _force = 11;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Invoke(nameof(ChangeForce), 5);
    }

    //private void FixedUpdate() => _rigidbody.AddForce(Vector3.up * _force);

    private void ChangeForce() => _force = 5;
}
