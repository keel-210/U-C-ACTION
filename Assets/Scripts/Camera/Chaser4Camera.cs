using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser4Camera : MonoBehaviour
{
    [SerializeField]
    Transform _Player;
    public Transform Player
    {
        get { return _Player; }
        set { _Player = value; }
    }
    [SerializeField]
    private Vector2 _Maxs;
    public Vector2 Maxs
    {
        get { return _Maxs; }
        set { _Maxs = value; }
    }
    [SerializeField]
    private Vector2 _Mins;
    public Vector2 Mins
    {
        get { return _Mins; }
        set { _Mins = value; }
    }
    [SerializeField]
    float _ChaserRatio;
    public float ChaserRatio
    {
        get { return _ChaserRatio; }
        set { _ChaserRatio = value; }
    }
    [SerializeField]
    float _OffsetY;
    public float OffsetY
    {
        get { return _OffsetY; }
        set { _OffsetY = value; }
    }
    bool Fixed;
    void FixedUpdate()
    {
        if (!Fixed)
        {
            Vector3 NextPos = Vector3.Lerp(transform.position, Player.position + new Vector3(0, 0, transform.position.z), ChaserRatio);
            float x = Mathf.Clamp(NextPos.x, Mins.x, Maxs.x);
            float y = Mathf.Clamp(NextPos.y, Mins.y + OffsetY, Maxs.y);
            transform.position = new Vector3(x, y, NextPos.z);
        }
    }
    public void FixCamera(Vector2 CamPos)
    {
        Fixed = true;
        transform.position = new Vector3(CamPos.x, CamPos.y, transform.position.z);
    }
#if UNITY_EDITOR
    void OnDrawGizmosSelected()
		{
			// カメラの移動可能な範囲(右下/左上)を取得
			Vector3 maxXMinY = new Vector3(Maxs.x, Mins.y);
			Vector3 minXMaxY = new Vector3 (Mins.x, Maxs.y);

			// カメラの移動範囲のGizmoを描画
			UnityEditor.Handles.DrawSolidRectangleWithOutline (
				new Vector3[]{ Maxs, maxXMinY, Mins, minXMaxY },
				new Color(1, 0, 0, 0.1f), Color.white);


			// カメラの描画する縦幅・横幅を取得
			Camera camera = GetComponent<Camera> ();
			float cameraWidthHalf = camera.orthographicSize * camera.aspect;
			Vector3 cameraMaxXMinY = new Vector2 (cameraWidthHalf, -camera.orthographicSize);
			Vector3 cameraMaxXMaxY = new Vector3 (cameraWidthHalf, camera.orthographicSize);

			// カメラの描画範囲のGizmoを描画描画			
			UnityEditor.Handles.DrawSolidRectangleWithOutline (new Vector3[]{
				Maxs + (Vector2)cameraMaxXMaxY, maxXMinY + cameraMaxXMinY,
				Mins - (Vector2)cameraMaxXMaxY, minXMaxY - cameraMaxXMinY
			}, new Color(1, 0, 0, 0.1f), Color.white);
		}
#endif
}

