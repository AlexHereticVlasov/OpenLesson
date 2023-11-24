using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _templates;

    private int _index = 0;

    private void Start() => InvokeRepeating(nameof(SpawnInQueue), 1, 1);

    private void Spawn()
    {
        int index = Random.Range(0, _templates.Length);
        Instantiate(_templates[index], new Vector3(0, 7, 0), Quaternion.identity);
    }

    private void SpawnInQueue()
    {
        Instantiate(_templates[_index], new Vector3(0, 7, 0), Quaternion.identity);
        _index++;
        _index %= _templates.Length;
    }
}
