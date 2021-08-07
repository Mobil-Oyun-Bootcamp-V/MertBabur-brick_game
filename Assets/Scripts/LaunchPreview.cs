using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPreview : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Vector3 _dragStartPoint;
    
    // Start is called before the first frame update
    void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    /**
     * Linerenderer için başlangıç noktasını set eder
     */
    public void SetStartPoint(Vector3 worldPoint)
    {
        _dragStartPoint = worldPoint;
        _lineRenderer.SetPosition(0,_dragStartPoint);
    }

    /**
     * Linerenderer için bitiş noktasını set eder
     */
    public void SetEndPoint(Vector3 worldPoint)
    {
        Vector3 pointOffset = worldPoint - _dragStartPoint;
        Vector3 endPoint = transform.position + pointOffset;
        
        _lineRenderer.SetPosition(1, endPoint);
    }
    
}
