using UnityEngine;

public class Move : MonoBehaviour
{
    private void Awake()
    {
        transform.Rotate(0, Random.Range(0f,360f), 0);          
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}