using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XGame.Fight.Util;

[ExecuteInEditMode]
public class PointSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public LineRenderer line1;
    public LineRenderer line2;

    public Transform ball_1;
    public Transform ball_2;

    public float offsetAngle = 10;
    public float factor = 3;
    public float dy = 1;
    [ExecuteInEditMode]
    void Update()
    {
        if (ball_1 == null || ball_2 == null) return;


        Vector3 myPos = this.transform.position;
        Vector3 dir = this.transform.forward * factor;
        //旋转轴
        float rad1 = offsetAngle * Mathf.Deg2Rad;
        float xa1 = dir.x * Mathf.Cos(rad1) + dir.z * Mathf.Sin(rad1);
        float za1 = dir.z * Mathf.Cos(rad1) - dir.x * Mathf.Sin(rad1);

        float xa2 = dir.x * Mathf.Cos(-rad1) + dir.z * Mathf.Sin(-rad1);
        float za2 = dir.z * Mathf.Cos(-rad1) - dir.x * Mathf.Sin(-rad1);


        ball_1.position = myPos + new Vector3(xa1, dy, za1);
        ball_2.position = myPos + new Vector3(xa2, dy, za2);

        ball_1.LookAt(ball_1.position + dir);
        ball_2.LookAt(ball_2.position + dir);
        List<Vector3> list_1 = new List<Vector3>() {
        myPos,
        ball_1.position,
        target.position,
        };
        List<Vector3> list_2 = BezierUtil.Bezier(list_1, 10);
        line1.positionCount = list_2.Count;
        line1.SetPositions(list_2.ToArray());

        list_1 = new List<Vector3>() {
        myPos,
        ball_2.position,
        target.position,
        };
        list_2 = BezierUtil.Bezier(list_1, 10);
        line2.positionCount = list_2.Count;
        line2.SetPositions(list_2.ToArray());
    }
}
