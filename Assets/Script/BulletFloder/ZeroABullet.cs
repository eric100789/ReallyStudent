using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class ZeroABullet : BaseBullet
    {
        [SerializeField] protected float SizeSpeed;
        [SerializeField] private float WaitTimeFly = 2.0f;
        private float setSpeed = 0f;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(WaitFlyAway());
            StartCoroutine(WaitForDead());
        }

        // Update is called once per frame
        override protected void Update()
        {
            this.gameObject.transform.localScale += new Vector3(SizeSpeed, SizeSpeed, 0);
            transform.Translate(setSpeed, -setSpeed, 0);
        }

        private IEnumerator WaitFlyAway()
        {
            yield return new WaitForSeconds(WaitTimeFly);
            setSpeed = speed;
        } 
    }
}
