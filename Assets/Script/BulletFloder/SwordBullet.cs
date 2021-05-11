using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.BulletFloder
{
    public class SwordBullet : BaseBullet
    {
        // -------variable---------
        [SerializeField] private readonly float waitTimeChange = 1.0f;
        private float setSpeed;
        // -------variable---------

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
                yield return new WaitForSeconds(waitTimeChange);
                setSpeed = -speed;
                yield return new WaitForSeconds(waitTimeChange);
            }
        }


    }
}