using UnityEngine;

public class init : MonoBehaviour
{
    public GameObject prefab;
    public float objinc = 1;
    public float minXPos = -10.0f;
    public float maxXPos = 10.0f;
    public float minYPos = -10.0f;
    public float maxYPos = 10.0f;

    public float objectSpeed = 1.0f;

    public float updateInterval = 1.0f;
    private float timer = 0.0f;

    public int maxObjectCount = 50;
    public static int objectCount = 0;

    public float destroyDistance = 900.0f;

    void Start()
    {
         for (float i = minXPos; i <= maxXPos; i+=objinc)
        {
            for (float j = minYPos; j <= maxYPos; j+=objinc)
            {
                Vector2 position = new Vector2(i, j);
                Instantiate(prefab, position, Quaternion.identity);
                objectCount++;
            }
        }
        Object.speed = objectSpeed;
    }

    private void FixedUpdate()
    {
        Object.speed = objectSpeed;
        Object.maxdistsq = destroyDistance;
        timer += Time.fixedDeltaTime;
        if (timer >= updateInterval && objectCount < maxObjectCount)
        {
            timer -= updateInterval;
            for (float i = minXPos; i <= maxXPos; i += objinc)
            {
                for (float j = minYPos; j <= maxYPos; j += objinc)
                {
                    Vector2 position = new Vector2(i, j);
                    Instantiate(prefab, position, Quaternion.identity);
                    objectCount++;
                }
            }
        }

    }
}
