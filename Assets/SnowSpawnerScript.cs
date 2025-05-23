using UnityEngine;

public class SnowSpawnerScript : MonoBehaviour
{
    public GameObject Snowobject;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnSnow();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnSnow();
            timer = 0;
        }
    }
    void spawnSnow()
    {
        Instantiate(Snowobject, transform.position, transform.rotation);
    }
}
