using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser4Camera : MonoBehaviour {
    [SerializeField]
    Transform _Player;
    public Transform Player
    {
        get { return _Player; }
        set { _Player = value; }
    }
    [SerializeField]
    float _Max_x;
    public float Max_x
    {
        get { return _Max_x; }
        set { _Max_x = value; }
    }
    [SerializeField]
    float _Min_x;
    public float Min_x
    {
        get { return _Min_x; }
        set { _Min_x = value; }
    }
    [SerializeField]
    float _Max_y;
    public float Max_y
    {
        get { return _Max_y; }
        set { _Max_y = value; }
    }
    [SerializeField]
    float _Min_y;
    public float Min_y
    {
        get { return _Min_y; }
        set { _Min_y = value; }
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

    void Update ()
    {
        Vector3 NextPos = Vector3.Lerp(transform.position, Player.position + new Vector3(0, OffsetY, transform.position.z), ChaserRatio);
        float x = Mathf.Clamp(NextPos.x, Min_x, Max_x);
        float y = Mathf.Clamp(NextPos.y, Min_y, Max_y);
        transform.position = new Vector3(x, y, NextPos.z);
    }
}
