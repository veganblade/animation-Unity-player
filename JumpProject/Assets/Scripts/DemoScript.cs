using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class DemoScript : MonoBehaviour
{
    private Rigidbody _rbCube;
    private void Start()
    {
        _rbCube.GetComponent<Rigidbody>();
    }
}
