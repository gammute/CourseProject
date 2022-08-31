using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ItemClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   public UnityEvent OnClick;
   public UnityEvent _cameraUp;
   [SerializeField] private GameObject _prefab;
   private Vector3 _floorPos;
   public Transform _floor;
   public GameObject _allFloors;
   private bool _isClick = false;
   private List<Vector3> allFloarPositions = new List<Vector3>
   {

   };
   public void OnPointerDown(PointerEventData eventData)
   {
        if (_isClick)
        {
            return;
        }
        //gameObject.AddComponent<Rigidbody>();
        _floorPos = _floor.transform.position;
        allFloarPositions.Add(new Vector3(_floorPos.x, _floorPos.y + 1, _floorPos.z));
        OnClick.Invoke();
        _isClick = true;
   }

   public void OnPointerUp(PointerEventData eventData)
   {
     _cameraUp.Invoke();
     Debug.Log("up");
   }

   public void build()
   {
        Instantiate (_prefab, allFloarPositions[0], Quaternion.identity);
        _prefab.transform.parent = _allFloors.transform;  
   }
}




