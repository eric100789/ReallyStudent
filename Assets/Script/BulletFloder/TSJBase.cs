using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{

    public class TSJBase : TSJBullet
    {

        private DateTime _stTime;

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
            transform.Translate(Dir.normalized * speed);
        }
    }
}