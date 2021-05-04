using UnityEngine;
using System;

namespace Script
{
    public class BaseBullet : MonoBehaviour
    {
        [SerializeField] public float speed = 48763;
        public Vector2 Dir;
        [SerializeField] protected float BreakTime = 3;
        private DateTime st_time;

        void Start()
        {
            st_time = DateTime.Now;
        }

        protected virtual void Tick()
        {
            //TODO: you shall implement these :P
            transform.Translate(Dir*speed);
        }

        protected void Update()
        {
            transform.Translate(Dir * speed);

            if (DateTime.Now.Subtract(st_time).Seconds >= BreakTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}