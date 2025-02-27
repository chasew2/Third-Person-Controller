using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public float rotateSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0f, rotateSpeed * Time.deltaTime,  0f);
    }
}
