using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CameraUpper : MonoBehaviour
{
     public Transform _camera;

     private Vector3 _cameraPos;
     private List<Vector3> allCameraPositions = new List<Vector3>
     {

     };

     public void Upper() 
     {
          _cameraPos = _camera.transform.position;
          allCameraPositions.Add(new Vector3(_cameraPos.x, _cameraPos.y + 1, _cameraPos.z));
          _camera.transform.position = allCameraPositions[0];
     }
}
