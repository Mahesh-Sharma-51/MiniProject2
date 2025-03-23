using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject GrassObject;
    public float spawnrate = 1;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spwanGrassObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanGrassObject();
            timer = 0;
        }
    }
    void spwanGrassObject()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(GrassObject, new Vector3(transform.position.x,Random.Range(lowestpoint, highestpoint),0), transform.rotation);
    }
}
