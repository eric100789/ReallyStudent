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
        [SerializeField] protected float BreakTime = 3;
        protected float Timer = 0;

        protected void Start()
        {
            _stTime = DateTime.Now;
            StartCoroutine(counter());
        }

        public void SetDir(Vector2 initDir)
        {
            Dir = initDir;
        }
        protected IEnumerator counter()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);
                Timer++;
            }
            

        }

     
        protected virtual void Update()
        {
            transform.Translate(Dir * speed);

            if (Timer == BreakTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}