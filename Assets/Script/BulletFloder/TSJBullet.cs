using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{
    public class TSJBullet : BaseBullet
    {
        [SerializeField] public List<GameObject> TSJBulletList;

        // Update is called once per frame
        protected IEnumerator Smallbullet()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.1f);
                var Bullet = Instantiate(TSJBulletList[Random.Range(0, TSJBulletList.Count)], transform.position, Quaternion.identity);
                Bullet.GetComponent<BaseBullet>().SetDir(Random.insideUnitCircle);
            }


        }
        override protected void Update()
        {
            StartCoroutine(Smallbullet());
            if (Timer >= BreakTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}