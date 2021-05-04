using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{   
    
    public class SwordBullet : BaseBullet
    {

        // Update is called once per frame
        protected override void Update()
        {
            if (Timer == BreakTime)
            {
                Destroy(this.gameObject);
            }
            if (Timer%2==1)
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