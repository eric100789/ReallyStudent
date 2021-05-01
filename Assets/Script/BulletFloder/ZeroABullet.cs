using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class ZeroABullet : BaseBullet
    {
        [SerializeField] protected float SizeSpeed;
        private DateTime _stTime;

        // Start is called before the first frame update
        void Start()
        {
            _stTime = DateTime.Now;
        }

        // Update is called once per frame
        override protected void Update()
        {
            if (DateTime.Now.Subtract(_stTime).Seconds >= 2)
            {
                transform.Translate(speed, -speed, 0);
            }

            if (DateTime.Now.Subtract(_stTime).Seconds >= 3)
            {
                Destroy(this.gameObject);
            }

            this.gameObject.transform.localScale += new Vector3(SizeSpeed, SizeSpeed, 0);

        }
    }
}
