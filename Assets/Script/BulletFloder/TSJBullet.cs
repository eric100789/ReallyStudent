using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{
    public class TSJBullet : BaseBullet
    {
        // -------variable---------
        [SerializeField] public List<GameObject> TSJBulletList;
        [SerializeField] private readonly float waitTimeShoot = 0.1f;
        // -------variable---------

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
                yield return new WaitForSeconds(waitTimeShoot);
            }
        }

    }
}