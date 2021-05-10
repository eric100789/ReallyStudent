using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMode : MonoBehaviour
{
    [SerializeField] private List<Sprite> BulletList;
    private SpriteRenderer spriteRenderer;
    private int Bulletmode = 0;
    // Start is called before the first frame update
    void Start()
    {   
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Bulletmode = (Bulletmode + 1) % BulletList.Count;
            spriteRenderer.sprite = BulletList[Bulletmode];
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Bulletmode = (Bulletmode - 1 + BulletList.Count) % BulletList.Count;
            spriteRenderer.sprite = BulletList[Bulletmode];
        }
        
    }
}
