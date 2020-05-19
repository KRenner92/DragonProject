using UnityEngine;

public class Movement : MonoBehaviour
{
    public float panSpeed = 20f;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("up"))
        {
            pos.z += panSpeed * Time.deltaTime;
        }

        transform.position = pos;
       
    }
}
