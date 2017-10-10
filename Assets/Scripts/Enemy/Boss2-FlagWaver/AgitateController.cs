using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AgitateController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Agitatees = new List<GameObject>();
    [SerializeField]
    float InstantTime;

    List<List<GameObject>> EnemyList = new List<List<GameObject>>();

    float Timer;
    private void Start()
    {
        for(int i = 0;i < Agitatees.Count; i++)
        {
            EnemyList.Add(new List<GameObject>());
            GameObject go = (GameObject)Instantiate(Agitatees[i]);
            go.SetActive(false);
            EnemyList[i].Add(go);
        }
    }
    void Update ()
    {
        Timer += Time.deltaTime;
        if (Timer > InstantTime)
        {
            GameObject go = GetInstance((Random.Range(0,Agitatees.Count)));
            go.transform.parent = transform.root;
            go.transform.localPosition = new Vector3(5 * (Random.value-0.5f), 5 * (Random.value - 0.5f), 0);
            Timer = 0;
        }
	}
    GameObject GetInstance(int EnemyNum)
    {
        GameObject obj = null;
        var list = EnemyList[EnemyNum].Where(go => !go.activeInHierarchy);
        if (list.Count() > 0 && list.First())
        {
            obj = list.First();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            obj = (GameObject)Instantiate(Agitatees[EnemyNum]);
            EnemyList[EnemyNum].Add(obj);
            return obj;
        }
    }
}
