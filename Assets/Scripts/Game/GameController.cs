using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public ParticleSystem particle;
    public Enemy[] enemy;

    public Enemy CurrentEnemyObject { get { return currentEnemyObject; } }

    Enemy currentEnemyObject;

    private void Update()
    {
        if (currentEnemyObject == null)
            StartCoroutine(SpawnEnemyWithParitlce());
    }

    IEnumerator SpawnEnemyWithParitlce()
    {
        Instantiate(particle, transform.position, transform.rotation);
        SpawnEnemy(0);
        yield return new WaitForSeconds(0.2f);
        currentEnemyObject.gameObject.SetActive(true);
    }

    void SpawnEnemy(int enemyNumber)
    {
        currentEnemyObject = Instantiate(enemy[enemyNumber], transform.position, transform.rotation);
        currentEnemyObject.gameObject.SetActive(false);
    }
}
