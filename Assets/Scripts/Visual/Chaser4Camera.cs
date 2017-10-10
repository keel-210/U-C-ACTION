using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser4Camera : MonoBehaviour
{
    [SerializeField]
    float ChaserRatio, offsetY;
    [SerializeField]
    List<Area> areas = new List<Area>();
    [SerializeField]
    Transform Target;
    public bool Fixed;
    Vector2 FixedPos;
    Area NowArea;
    CameraFixType fixType;
    private void Start()
    {
        NowArea = areas[0];
        Target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate()
    {
        Vector3 NextPos = Vector3.MoveTowards(transform.position, Target.position + new Vector3(0, 0, transform.position.z), ChaserRatio);
        foreach (Area a in areas)
        {
            Vector2 pos = NextPos;
            if (a.Mins.x <= pos.x && pos.x <= a.Maxs.x)
            {
                NowArea = a;
                if (a.Mins.y <= pos.y && pos.y <= a.Maxs.y)
                {
                    NowArea = a;
                }
            }
        }
        if (!Fixed)
        {
            float x = Mathf.Clamp(NextPos.x, NowArea.Mins.x, NowArea.Maxs.x);
            float y = Mathf.Clamp(NextPos.y, NowArea.Mins.y, NowArea.Maxs.y);
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(x, y, NextPos.z),ChaserRatio);
        }
        else
        {
            switch (fixType)
            {
                case CameraFixType.xFix:
                    Vector3 NextPosX = Vector3.MoveTowards(transform.position, new Vector3(FixedPos.x, Target.position.y, transform.position.z), ChaserRatio);
                    float y = Mathf.Clamp(NextPosX.y, NowArea.Mins.y, NowArea.Maxs.y);
                    transform.position = new Vector3(NextPosX.x, y, NextPosX.z);
                    break;
                case CameraFixType.yFix:
                    Vector3 NextPosY = Vector3.MoveTowards(transform.position, new Vector3(Target.position.x, FixedPos.y, transform.position.z), ChaserRatio);
                    float x = Mathf.Clamp(NextPosY.x, NowArea.Mins.x, NowArea.Maxs.x);
                    transform.position = new Vector3(x, NextPosY.y, NextPosY.z);
                    break;
                case CameraFixType.xyFix:
                    Vector3 NextPosXY = Vector3.MoveTowards(transform.position, new Vector3(Target.position.x, FixedPos.y, transform.position.z), ChaserRatio);
                    transform.position = NextPosXY;
                    break;
            }
        }
    }

    public void Fix(Vector2 CamPos, CameraFixType fixType)
    {
        Fixed = true;
        FixedPos = CamPos;
    }
    public void UnFix()
    {
        Fixed = false;
    }

    [System.Serializable]
    public class Area
    {
        public Vector2 Maxs, Mins;
    }
#if UNITY_EDITOR
    void OnDrawGizmosSelected()
    {
        foreach (Area a in areas)
        {
            // カメラの移動可能な範囲(右下/左上)を取得
            Vector3 maxXMinY = new Vector3(a.Maxs.x, a.Mins.y);
            Vector3 minXMaxY = new Vector3(a.Mins.x, a.Maxs.y);

            // カメラの移動範囲のGizmoを描画
            UnityEditor.Handles.DrawSolidRectangleWithOutline(
                new Vector3[] { a.Maxs, maxXMinY, a.Mins, minXMaxY },
                new Color(0, 0, 1, 0.2f), Color.white);


            // カメラの描画する縦幅・横幅を取得
            Camera camera = GetComponent<Camera>();
            float cameraWidthHalf = camera.orthographicSize * camera.aspect;
            Vector3 cameraMaxXMinY = new Vector2(cameraWidthHalf, -camera.orthographicSize);
            Vector3 cameraMaxXMaxY = new Vector3(cameraWidthHalf, camera.orthographicSize);

            // カメラの描画範囲のGizmoを描画描画			
            UnityEditor.Handles.DrawSolidRectangleWithOutline(new Vector3[]{
                a.Maxs + (Vector2)cameraMaxXMaxY, maxXMinY + cameraMaxXMinY,
                a.Mins - (Vector2)cameraMaxXMaxY, minXMaxY - cameraMaxXMinY
            }, new Color(0, 0, 0, 0), Color.white);
        }
    }
#endif
}
public enum CameraFixType
{
    xFix, yFix, xyFix
}
