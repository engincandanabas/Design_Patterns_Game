using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItem
{
    public GameObject prefab;
    public int amount;
    public bool expandable;

}
public class Pool : MonoBehaviour
{
    public static Pool singleton;
    public List<PoolItem> poolItems;
    public List<GameObject> pooledItems;
    void Awake()
    {
        singleton=this;
    }
    private void Start() {
        pooledItems= new List<GameObject>();
        foreach(PoolItem item in poolItems)
        {
            for(int i=0;i<item.amount;i++)
            {
                GameObject obj=Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }

    }
    public GameObject GetPooledObject(string tag)
    {
        for(int i=0;i<pooledItems.Count;i++)
        {
            if(!pooledItems[i].activeInHierarchy && pooledItems[i].tag==tag)
            {
                return pooledItems[i];
            }
        }
        foreach(PoolItem item in poolItems)
        {
            if(item.prefab.tag==tag && item.expandable)
            {
                GameObject gameObject = Instantiate(item.prefab);
                gameObject.SetActive(false);
                pooledItems.Add(gameObject);
                return gameObject;
            }
        }
        return null;
    }
}
