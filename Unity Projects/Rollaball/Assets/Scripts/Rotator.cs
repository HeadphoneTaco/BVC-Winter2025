using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Rotate the object on x, y , and z axies by specified amounts, adjusted for framerate
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
