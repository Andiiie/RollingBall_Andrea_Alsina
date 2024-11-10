using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot_capsule : MonoBehaviour
{
    [SerializeField] int rotar;
    
    void Update()
    {
        transform.Rotate(new Vector3 (0, rotar, 0) * Time.deltaTime);
    }
}
