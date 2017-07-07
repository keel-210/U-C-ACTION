using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser4Camera : MonoBehaviour {
    [SerializeField]
    GameObject _Player;
    public GameObject Player
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
        Vector3 NextPos = Vector3.Lerp(transform.position + new Vector3(0, OffsetY, 0), Player.transform.position, ChaserRatio);
        if(NextPos.x <= Max_x && NextPos.x >= Min_x)
        {
            transform.position = new Vector3(NextPos.x,transform.position.y,transform.position.z);
        }
        else if (NextPos.x > Max_x)
        {
            transform.position = new Vector3(Max_x, transform.position.y, transform.position.z);
        }
        else if (NextPos.x < Min_x)
        {
            transform.position = new Vector3(Min_x, transform.position.y, transform.position.z);
        }
        if (NextPos.y <= Max_y && NextPos.y >= Min_y)
        {
            transform.position = new Vector3(transform.position.x, NextPos.y, transform.position.z);
        }
        else if (NextPos.y > Max_y)
        {
            transform.position = new Vector3(transform.position.x, Max_y, transform.position.z);
        }
        else if (NextPos.y < Min_y)
        {
            transform.position = new Vector3(transform.position.x, Min_y, transform.position.z);
        }
    }
}
