using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class SwordBullet : BaseBullet
    {
        private DateTime _stTime;

        private void Start()
        {
            _stTime = DateTime.Now;
        }

        // Update is called once per frame
        protected override void Update()
        {
            if (DateTime.Now.Subtract(_stTime).Seconds >= 10)
            {
                Destroy(this.gameObject);
            }

            if ((DateTime.Now.Subtract(_stTime).Seconds)%2==1)
            {
                transform.Translate(speed, -speed, 0);
            }
            else
            {
                transform.Translate(speed, speed, 0);
            }

        }

           
    }
}