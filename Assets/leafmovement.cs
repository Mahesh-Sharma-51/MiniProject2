using UnityEngine;

public class leafmovement : MonoBehaviour
{
    public float movespeed = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed);
    }
}
