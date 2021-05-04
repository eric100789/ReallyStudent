using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.BulletFloder
{
    public class SwordBullet : BaseBullet
    {
        [SerializeField] private float WaitTimeChange = 1.0f;
        private float setSpeed;

        private void Start()
        {
            StartCoroutine(WaitForChange());
            StartCoroutine(WaitForDead()); 
        }

        // Update is called once per frame
        protected override void Update()
        {
            transform.Translate(speed, setSpeed, 0);
        }

        private IEnumerator WaitForChange()
        {
            while (true)
            {
                setSpeed = speed;
                yield return new WaitForSeconds(WaitTimeChange);
                setSpeed = -speed;
                yield return new WaitForSeconds(WaitTimeChange);
            }
        }


    }
}