using UnityEngine;

namespace Script
{
    public class BaseBullet : MonoBehaviour
    {
        [SerializeField] protected float speed = 48763;
        public Vector2 Dir;

        protected virtual void Tick()
        {
            //TODO: you shall implement these :P
            transform.Translate(Dir*speed);
        }
    }
}