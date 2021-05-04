using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Script.BulletFloder
{
    public class BaseBullet : MonoBehaviour
    {
        [SerializeField] protected float speed;
        protected Vector2 Dir;
        private DateTime _stTime;

        private void Start()
        {
            _stTime = DateTime.Now;
        }

        public void SetDir(Vector2 initDir)
        {
            Dir = initDir;
        }

        protected virtual void Update()
        {
            if (DateTime.Now.Subtract(_stTime).Seconds >= 1)
            {
                Destroy(this.gameObject);
            }
            transform.Translate(Dir.normalized * speed);
        }
    }
}