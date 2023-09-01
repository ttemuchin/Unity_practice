using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public a enemyPrefab;
    public int countEnemy = 2;
    public int zaderjka = 5;
    //public bool isActive = false;

    private void Start()
    {
        StartCoroutine(SpawnWithTimeOut());
    }

    IEnumerator SpawnWithTimeOut()
    {
        for (int i = 0; i < countEnemy; i++)
        {
            //if (isActive)
            //{
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(zaderjka);
            //}       
        }
    }
}
