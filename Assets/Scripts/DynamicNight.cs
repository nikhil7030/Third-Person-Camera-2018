using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicNight : MonoBehaviour
{
    private Light lightSource;
    [SerializeField] [Range(0, 100)] private float Speed = 10f;
    [SerializeField] [Range(0, 50)] private float skyBoxSpeed;
    private void Start()
    {
        lightSource = GetComponent<Light>();
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, Speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);

        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyBoxSpeed);
    }
}
