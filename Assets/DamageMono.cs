using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMono : MonoBehaviour
{

    [SerializeField] private GameObject damageSphereGameObject;
    [SerializeField] private GameObject pivotGameObject;
    [SerializeField] private float randomRangeOfPivotPos;
    private Vector3 initPivotPosition;

    private void Start()
    {
        initPivotPosition = pivotGameObject.transform.position;
    }

    public void Damage()
    {
        RandomRotatePivot();
        //RandomPositionPivot();
        ShootSphereToPivot();
    }



    private void RandomRotatePivot()
    {
        var xAngle = Random.Range(0, 360);
        var yAngle = Random.Range(0, 360);
        var zAngle = Random.Range(0, 360);
        pivotGameObject.transform.Rotate(xAngle, yAngle, zAngle);
    }

    private void RandomPositionPivot()
    {
        var x = Random.Range(0, randomRangeOfPivotPos);
        var y = Random.Range(0, randomRangeOfPivotPos);
        var z = Random.Range(0, randomRangeOfPivotPos);
        pivotGameObject.transform.position = initPivotPosition + new Vector3(x, y, z);
    }

    private void ShootSphereToPivot()
    {
        damageSphereGameObject.transform.localPosition = new Vector3(0, 5, 0);

        var rd = damageSphereGameObject.GetComponent<Rigidbody>();
        var direction = (pivotGameObject.transform.position - damageSphereGameObject.transform.position).normalized;
        var forceAmount = 30;

        rd.velocity = Vector3.zero;

        rd.AddForce(forceAmount * direction, ForceMode.Impulse);
    }
}
