using UnityEngine;
using Unity.Mathematics;

public class Object : MonoBehaviour
{
    public Rigidbody2D rg;
    public static float speed;
    public static float maxdistsq = 900.0f;

    private float deltaTStationary = 0.0f;
    private float maxdeltaTStationary = 3.0f;
 
    private Vector2 fieldVector(Vector2 coordinates)
    {
        return new Vector2(-coordinates.y * (coordinates.x), coordinates.x * (coordinates.y));
    }
    private void FixedUpdate()
    {
        if (rg.linearVelocity == Vector2.zero)
            deltaTStationary += Time.fixedDeltaTime;
        else
            deltaTStationary = 0.0f;
        if (rg.position.sqrMagnitude > maxdistsq || deltaTStationary > maxdeltaTStationary)
        {
            Destroy(gameObject);
            init.objectCount--;
        }
        rg.linearVelocity = fieldVector(rg.position);
    }
}
