using UnityEngine;
public class MoveToMouse : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject character;
    public bool isStarted = false;
    public GameObject carSound;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            isStarted = true;
        if (isStarted == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            carSound.SetActive(true);
        }
    }
}
