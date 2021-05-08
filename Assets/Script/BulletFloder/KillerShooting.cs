using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script.BulletFloder
{

    public class KillerShooting : MonoBehaviour
    {
        // -------variable---------
        [SerializeField] public List<GameObject> BulletList;
        //--------variable---------

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {               
                var Bullet = Instantiate(BulletList[Random.Range(0, BulletList.Count)], transform.position, Quaternion.identity);
                Bullet.GetComponent<BaseBullet>().SetDir(Random.insideUnitCircle);
            }
        }
    }
}