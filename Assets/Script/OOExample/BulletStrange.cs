using System;
using Unity.Mathematics;
using UnityEngine;

namespace Script.OOExample
{
    public class BulletStrange : BulletBase
    {
        private Vector2 _startPos;
        [SerializeField] private float rad = 3;
        private DateTime _stTime;
        
        private void Start()
        {
            var position = transform.position;
            _startPos = new Vector2(position.x, position.y);
            _stTime = DateTime.Now;
        }

        protected override void Update()
        {
            var remainTime = DateTime.Now.Subtract(_stTime).Seconds;
            if (remainTime >= 3)
            {
                Destroy(this.gameObject);
            }
            
            /* rotate 1 degree every 0.1 s */
            var angle = (DateTime.Now.Subtract(_stTime).Milliseconds/100)%360;
            var degree = angle * 180.0f;
            degree *= speed;
            
            var baseDeg = math.acos(Dir.x) * (Dir.y > 0 ? 1 : -1);
            
            transform.position = _startPos+rad*(new Vector2(math.cos(baseDeg+degree), math.sin(baseDeg+degree))) ;
        }
    }
}