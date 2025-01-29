using UnityEngine;

public class LiveDemo : MonoBehaviour
{
    public float yawDegreesPerSecond = 45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(0f, yawDegreesPerSecond * Time.deltaTime, 0f);
    }
}
