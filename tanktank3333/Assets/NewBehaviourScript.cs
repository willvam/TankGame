using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 1.0f;
    public float rotatespeed = 1.0f;

    public Transform tower;
    public float towerSpeed = 1;

    public Transform barrel;
    public float barrelSpeed = 5;
    private float angle;
    public float minAngle = -5;
    public float maxAngle = 25;

    public Renderer trackL; //左履帶
    public Renderer trackR; //右履帶
    public float trackSpeed = 0.04f;//履帶轉動速度

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        transform.Translate(0, 0, movespeed * -v);
        transform.Rotate(0, rotatespeed * h, 0);

        var x = Input.GetAxis("Mouse X");
        tower.Rotate(0, 0, x * towerSpeed);

        angle += Input.GetAxis("Mouse ScrollWheel") * barrelSpeed;
        angle = Mathf.Clamp(angle, minAngle, maxAngle);
        Vector3 barrelAngle = barrel.localEulerAngles;
        barrelAngle.x = angle;
        barrel.localEulerAngles = barrelAngle;

        Vector2 trackLOffset = trackL.material.mainTextureOffset;
        trackLOffset.x += v != 0 ? trackSpeed * v : trackSpeed * h;
        trackL.material.mainTextureOffset = trackLOffset;

        Vector2 trackROffset = trackR.material.mainTextureOffset;
        trackROffset.x += v != 0 ? trackSpeed * v : trackSpeed * -h;
        trackR.material.mainTextureOffset = trackROffset;

    }



}
