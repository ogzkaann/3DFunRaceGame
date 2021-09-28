using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PaintingTheWall : MonoBehaviour
{
    [SerializeField] Camera cam = null;
    [SerializeField] LineRenderer lineRenderer = null;
    private Vector3 mousePos;
    private Vector3 Pos;
    private Vector3 previousPos;
    public List<Vector3> linePositions = new List<Vector3>();
    public float minimumDistance = 0.05f;
    public float distance = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = +10;
            Pos = cam.ScreenToWorldPoint(mousePos);
            previousPos = Pos;
            linePositions.Add(Pos);
            lineRenderer.numCornerVertices = lineRenderer.numCapVertices = 8;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                mousePos = Input.mousePosition;
                mousePos.z = +10;
                Pos = cam.ScreenToWorldPoint(mousePos);
                distance = Vector3.Distance(Pos, previousPos);
                if (distance >= minimumDistance)
                {
                    previousPos = Pos;
                    linePositions.Add(Pos);
                    lineRenderer.positionCount = linePositions.Count;
                    lineRenderer.SetPositions(linePositions.ToArray());
                    lineRenderer.numCornerVertices = lineRenderer.numCapVertices = 8;
                }
            }
        }
    }
}
