using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser4Camera : MonoBehaviour
{
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

    Transform Player;
    public bool Fixed;
    Vector2 FixedPos;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }
    void FixedUpdate()
    {
        if (!Fixed)
        {
            Vector3 NextPos = Vector3.MoveTowards(transform.position, Player.position + new Vector3(0, 0, transform.position.z), ChaserRatio);
            float x = Mathf.Clamp(NextPos.x, Mins.x, Maxs.x);
            float y = Mathf.Clamp(NextPos.y, Mins.y, Maxs.y);
            transform.position = new Vector3(x, y, NextPos.z);
        }
        else
        {
            Vector3 NextPos = Vector3.MoveTowards(transform.position, new Vector3(FixedPos.x,Player.position.y,transform.position.z), ChaserRatio);
            float y = Mathf.Clamp(NextPos.y, Mins.y, Maxs.y);
            transform.position = new Vector3(NextPos.x, y, NextPos.z);
        }
    }

    public void Fix(Vector2 CamPos)
    {
        Fixed = true;
        FixedPos = CamPos;
    }
    public void UnFix()
    {
        Fixed = false;
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

