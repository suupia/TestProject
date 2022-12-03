using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class CutMono : MonoBehaviour
{
    [SerializeField] private GameObject cutterGameObject;
    [SerializeField] private GameObject pivotGameObject;
    [SerializeField] private float randomRangeOfCutterPos;
    private Vector3 initPivotPosition;

    private void Start()
    {
         initPivotPosition = pivotGameObject.transform.position;
    }

    public void Cut()
    {
        RandomRotatePivot();
        RandomPositionPivot();

    }

    private void RandomRotatePivot()
    {
        var xAngle = Random.Range(0, 360);
        var yAngle = Random.Range(0, 360);
        var zAngle = Random.Range(0, 360);
        pivotGameObject.transform.Rotate(xAngle,yAngle,zAngle);
    }

    private void RandomPositionPivot()
    {
        var x = Random.Range(0, randomRangeOfCutterPos);
        var y = Random.Range(0, randomRangeOfCutterPos);
        var z = Random.Range(0, randomRangeOfCutterPos);
        pivotGameObject.transform.position = initPivotPosition + new Vector3(x,y,z);
    }
}
