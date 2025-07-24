using Unity.VisualScripting;
using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
