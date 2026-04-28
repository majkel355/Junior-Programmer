using UnityEngine;

public class ProprellerSpin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private float spinSpeed = 4000f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, spinSpeed * Time.deltaTime);
    }
}
