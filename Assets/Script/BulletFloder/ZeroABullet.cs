using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class ZeroABullet : BaseBullet
    {
        [SerializeField] protected float SizeSpeed;
        [SerializeField] protected float FlyTime = 2;

        // Start is called before the first frame update
        /*void Start()
        {
        
        }*/

        // Update is called once per frame
        override protected void Update()
        {
            if (Timer >= FlyTime)
            {
                transform.Translate(speed, -speed, 0);
            }

            if (Timer >= BreakTime)
            {
                Destroy(this.gameObject);
            }

            this.gameObject.transform.localScale += new Vector3(SizeSpeed, SizeSpeed, 0);

        }
    }
}
