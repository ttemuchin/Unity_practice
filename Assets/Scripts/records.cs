/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class a : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Hero>().transform;
    }

    private void Update()
    {
        agent.SetDestination(player.position);
    }
}*/
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public EnemyBall enemyPrefab;
    public int countEnemy = 2;

    private void Start()
    {
        StartCoroutine(SpawnWithTimeOut());
    }

    IEnumerator SpawnWithTimeOut()
    {
        for (int i = 0; i < countEnemy; i++)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(4);
        }
    }
}*/