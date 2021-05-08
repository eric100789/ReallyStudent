using System.Collections;
using UnityEngine;

namespace Script.BulletFloder
{
    public class BaseBullet : MonoBehaviour
    {
        // -------variable---------
        [SerializeField] protected float speed;
        [SerializeField] protected float WaitTimeDead = 1.0f;
        protected Vector2 Dir;
        // -------variable---------

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
            yield return new WaitForSeconds(WaitTimeDead);
            Destroy(this.gameObject);
        }

    }
}