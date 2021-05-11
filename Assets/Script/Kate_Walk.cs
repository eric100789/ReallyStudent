using UnityEngine;

public class Kate_Walk : MonoBehaviour
{
    // -------variable---------
    [SerializeField] private float speed = 0.06f;
    // -------variable---------

    private void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.right * speed);
        }

    }
}