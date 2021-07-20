using UnityEngine;

public class LookAt : MonoBehaviour
{
    Transform mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCam);
    }
}
