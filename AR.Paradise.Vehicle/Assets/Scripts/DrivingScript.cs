using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingScript : MonoBehaviour
{
    [SerializeField] private float MaxAngle=30;
    [SerializeField] private float MaxTorque = 300;

    [SerializeField] private WheelCollider[] wheelCollieders=null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Angle = MaxAngle * Input.GetAxis("Horizontal");
        float Torque = MaxTorque * Input.GetAxis("Vertical");

        wheelCollieders[0].steerAngle = Angle;
        wheelCollieders[1].steerAngle = Angle;

        wheelCollieders[2].motorTorque = Torque;
        wheelCollieders[3].motorTorque = Torque;

        foreach(WheelCollider wheelCollieder in wheelCollieders)
        {

            Vector3 pos ;
            Quaternion Rot;

            wheelCollieder.GetWorldPose(out pos, out Rot);

            Transform wheel = wheelCollieder.transform.GetChild(0);

           
            
            wheel.position = pos;
            wheel.rotation = Rot;
        }
    }
}
