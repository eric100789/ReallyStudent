using System.Collections;
using UnityEngine;

namespace Script.BulletFloder
{
    public class ZeroABullet : BaseBullet
    {
        // -------variable---------
        [SerializeField] protected float SizeSpeed;
        [SerializeField] private readonly float waitTimeFly = 2.0f;
        private float setSpeed = 0f;
        // -------variable---------

        void Start()
        {
            StartCoroutine(WaitFlyAway());
            StartCoroutine(WaitForDead());
        }

        override protected void Update()
        {
            this.gameObject.transform.localScale += new Vector3(SizeSpeed, SizeSpeed, 0);
            transform.Translate(setSpeed, -setSpeed, 0);
        }

        private IEnumerator WaitFlyAway()
        {
            yield return new WaitForSeconds(waitTimeFly);
            setSpeed = speed;
        } 
    }
}
