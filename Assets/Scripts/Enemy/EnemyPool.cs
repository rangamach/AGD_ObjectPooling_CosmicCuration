using CosmicCuration.Bullets;
using CosmicCuration.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CosmicCuration.Bullets.BulletPool;

public class EnemyPool
{
    private EnemyView enemyView;
    private EnemyData enemydata;
    private List<PooledEnemy> pooledEnemies = new List<PooledEnemy>();
    public EnemyPool(EnemyView view, EnemyData data)
    {
        this.enemyView = view;
        this.enemydata = data;
    }
    public EnemyController GetEnemy()
    {
        if (pooledEnemies.Count > 0)
        {
            PooledEnemy pooledEnemy = pooledEnemies.Find(item => !item.isUsed);
            if (pooledEnemy != null)
            {
                pooledEnemy.isUsed = true;
                return pooledEnemy.Enemy;
            }
        }
        return CreateNewPooledEnemy();
    }
    private EnemyController CreateNewPooledEnemy()
    {
        PooledEnemy pooledEnemy = new PooledEnemy();
        pooledEnemy.Enemy = new EnemyController(enemyView,enemydata);
        pooledEnemy.isUsed = true;
        pooledEnemies.Add(pooledEnemy);
        return pooledEnemy.Enemy;
    }
    public void ReturnToEnemyPool(EnemyController returnedEnemy)
    {
        PooledEnemy pooledEnemy = pooledEnemies.Find(item => item.Enemy.Equals(returnedEnemy));
        pooledEnemy.isUsed = false;
    }
    
    public class PooledEnemy
    {
        public EnemyController Enemy;
        public bool isUsed;
    }
}
