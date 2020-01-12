using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicDayNight : MonoBehaviour
{

    [SerializeField][Range(0,100)]private float Speed = 10f;
    [SerializeField][Range(0,50)]private float skyBoxSpeed;
    [SerializeField] private Material daySkyBox;
    [SerializeField] private Material nightSkyBox;
    private Light lightSource;
    private GameObject Moon;
    [SerializeField] private Water water;
    
    

    private void Start()
    {
        lightSource = GetComponent<Light>();
        
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, Speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
        
        if (transform.rotation.x < 0)
        {
            RenderSettings.skybox = nightSkyBox;
            lightSource.intensity = 0f;
            water.ChangeReflection(true);

        }
        else
        {
            RenderSettings.skybox = daySkyBox;
            lightSource.intensity = 0.68f;
            water.ChangeReflection(false);

        }

        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyBoxSpeed);
    }
}
