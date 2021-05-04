using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{
    public class TSJBullet : BaseBullet
    {
        private float ftime;
        [SerializeField] public List<GameObject> TSJBulletList;
        [SerializeField] float WaitTimeShoot = 0.1f;

        void Start()
        {
            StartCoroutine(WaitForDead());
            StartCoroutine(WaitForShoot());
        }

        override protected void Update()
        {
        }

        private IEnumerator WaitForShoot()
        {
            while (true)
            {
                var Bullet = Instantiate(TSJBulletList[Random.Range(0, TSJBulletList.Count)], transform.position, Quaternion.identity);
                Bullet.GetComponent<BaseBullet>().SetDir(Random.insideUnitCircle);
                yield return new WaitForSeconds(WaitTimeShoot);
            }
        }

    }
}