using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructClass2 : MonoBehaviour
{
    public struct PathStruct
    {
        public string path;
    }


    public class PathClass
    {
        public string path;
    }

    private List<PathStruct> pathStructList = new List<PathStruct>();
    private List<PathClass> pathClassList = new List<PathClass>();
    private List<PathStruct> pathStructmodifyList = new List<PathStruct>();

    void Start()
    {
        PathStruct mps = new PathStruct();
        mps.path = "def";
        pathStructmodifyList.Add(mps);
    }

    void TestStruct()
    {
        PathStruct mps = new PathStruct();
        mps.path = "def";
        pathStructList.Add(mps);
    }

    void TestClass()
    {
        PathClass mps = new PathClass();
        mps.path = "def";
        pathClassList.Add(mps);
    }

    void Test_struct_modify()
    {
        PathStruct mst = pathStructmodifyList[0];
        mst.path = "new";
        pathStructmodifyList[0] = mst;
    }

    // Update is called once per frame
    void Update()
    {
        //TestStruct();
        //TestClass();
        Test_struct_modify();
    }
}
