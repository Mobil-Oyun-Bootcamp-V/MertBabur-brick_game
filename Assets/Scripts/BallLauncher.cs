using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallLauncher : MonoBehaviour
{

    private Vector3 _startDragPosition;
    private Vector3 _endDragPosition;
    private LaunchPreview _launchPreview;

    [SerializeField] private GameObject ballPrefab;

    private void Awake()
    {
        _launchPreview = GetComponent<LaunchPreview>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.back * -10;
        
        if (Input.GetMouseButtonDown(0)) // ekrana tıklandı ise
        {
            StartDrag(worldPosition);
        }
        else if (Input.GetMouseButton(0))
        {
            ContinueDrag(worldPosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            EndDrag(worldPosition);
        }
    }

    private void StartDrag(Vector3 worldPosition)
    {
        _startDragPosition = worldPosition;
        _launchPreview.SetStartPoint(transform.position);
        
    }

    private void ContinueDrag(Vector3 worldPosition)
    {
        _endDragPosition = worldPosition;
        Vector3 direction = _endDragPosition - _startDragPosition;
        _launchPreview.SetEndPoint(transform.position - direction);
    }
    
    private void EndDrag(Vector3 worldPosition)
    {
        Vector3 direction = _endDragPosition - _startDragPosition;
        direction.Normalize();

        var ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().AddForce(-direction);
    }
    
}
