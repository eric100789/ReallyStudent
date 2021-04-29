using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script.OOExample
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] private List<GameObject> bullets;
        [SerializeField] private float speed = 0.5f;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                var o = Instantiate(bullets[Random.Range(0, bullets.Count)], transform.position, Quaternion.identity);
                o.GetComponent<BulletBase>().SetDir(Random.insideUnitCircle);
            }

            var res = new Vector2(0, 0);
            if (Input.GetKey(KeyCode.A))
                res += Vector2.left;
            if (Input.GetKey(KeyCode.S))
                res += Vector2.down;
            if (Input.GetKey(KeyCode.D))
                res += Vector2.right;
            if (Input.GetKey(KeyCode.W))
                res += Vector2.up;
            
            transform.Translate(res.normalized * speed);
        }
    }
}