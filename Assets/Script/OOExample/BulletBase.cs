using System;
using UnityEngine;

namespace Script.OOExample
{
    public class BulletBase : MonoBehaviour
    {
        [SerializeField] protected float speed;
        protected Vector3 Dir;
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
            if (DateTime.Now.Subtract(_stTime).Seconds >= 3)
            {
                Destroy(this.gameObject);
            }
            transform.Translate(Dir.normalized * speed);
        }
    }
}