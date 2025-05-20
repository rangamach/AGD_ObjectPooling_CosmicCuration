using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        private BulletView bulletView;
        private BulletScriptableObject bulletScriptableObject;
        private List<PooledBullet> pooledBullets = new List<PooledBullet>();
        public BulletPool(BulletView view, BulletScriptableObject scriptableObject)
        {
            this.bulletView = view;
            this.bulletScriptableObject = scriptableObject;
        }
        public class PooledBullet
        {
            public BulletController Bullet;
            public bool isUsed;
        }
    }

}