using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private NavMeshAgent _agent;

    private void Start() => InvokeRepeating(nameof(Moving), 0.25f, 0.25f);

    private void Moving() => _agent.SetDestination(_player.position);
}
