using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player;
    

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _player.Move(Vector3.forward, 0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _player.Move(Vector3.back, 2, 3);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _player.Move(Vector3.right, 0, 2);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _player.Move(Vector3.left, 1, 3);
        }
    }
}
