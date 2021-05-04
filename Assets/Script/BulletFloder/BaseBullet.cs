using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class BaseBullet : MonoBehaviour
    {
        [SerializeField] protected float speed;
        [SerializeField] private float WaitTimeDead = 1.0f;
        protected Vector2 Dir;

        private void Start()
        {
            StartCoroutine(WaitForDead());
        }

        public void SetDir(Vector2 initDir)
        {
            Dir = initDir;
        }

        protected virtual void Update()
        {
            transform.Translate(Dir.normalized * speed);
        }

        protected IEnumerator WaitForDead()
        {
            while (true)
            {
                yield return new WaitForSeconds(WaitTimeDead);
                Destroy(this.gameObject);
            }
        }

    }
}