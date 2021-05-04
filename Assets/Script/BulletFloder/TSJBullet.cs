using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{
    public class TSJBullet : BaseBullet
    {
        private DateTime _stTime;
        private float ftime;
        [SerializeField] public List<GameObject> TSJBulletList;

        void Start()
        {
            _stTime = DateTime.Now;
        }

        // Update is called once per frame
        override protected void Update()
        {
            if (DateTime.Now.Subtract(_stTime).Seconds >= 3)
            {
                Destroy(this.gameObject);
            }

            ftime += Time.deltaTime;

            if (ftime >= 0.1f)
            {
                var Bullet = Instantiate(TSJBulletList[Random.Range(0, TSJBulletList.Count)], transform.position, Quaternion.identity);
                Bullet.GetComponent<BaseBullet>().SetDir(Random.insideUnitCircle);
                ftime = 0f;
            }

        }
    }
}