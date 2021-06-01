using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    [SerializeField] private GameObject orbitingObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform orbitTransform = orbitingObject.transform;
        Vector3 orbitPosition = orbitTransform.position;
        Vector3 orbitAxis = Vector3.up;
        float orbitAngle = 1.0f;

        transform.RotateAround(orbitPosition, orbitAxis, orbitAngle);
    }
}
