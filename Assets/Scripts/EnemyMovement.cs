using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private const float SearchRate = 0.25f;

    [SerializeField] private Transform _player;
    [SerializeField] private NavMeshAgent _agent;

    private void Start() => InvokeRepeating(nameof(Moving), SearchRate, SearchRate);

    private void Moving() => _agent.SetDestination(_player.position);
}
