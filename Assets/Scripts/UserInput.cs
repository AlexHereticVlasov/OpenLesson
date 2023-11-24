using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player;
    

    private void Update()
    {
        float x = 0;
        float z = 0;

        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        _player.Move(x, z);
    }
}
