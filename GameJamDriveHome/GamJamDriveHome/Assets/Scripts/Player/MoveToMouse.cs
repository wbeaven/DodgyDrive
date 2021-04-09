using UnityEngine;
public class MoveToMouse : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject character;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
