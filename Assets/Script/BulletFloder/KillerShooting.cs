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
        protected int BulletMode = 0;
        //--------variable---------

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                BulletMode = (BulletMode + 1) % BulletList.Count;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                BulletMode = (BulletMode - 1 + BulletList.Count) % BulletList.Count;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                var Bullet = Instantiate(BulletList[BulletMode], transform.position, Quaternion.identity);
                Bullet.GetComponent<BaseBullet>().SetDir(Random.insideUnitCircle);
            }
        }
    }
}