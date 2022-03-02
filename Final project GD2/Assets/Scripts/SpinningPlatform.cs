using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPlatform : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    public float speed = 500f;
    public GameObject Platform;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Platform.transform.Rotate(rotation * Time.deltaTime);
    }

    private void OnCollisionEnter(Collider collider)
    {
        
        Platform.transform.Rotate(rotation * Time.deltaTime);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    */
}
