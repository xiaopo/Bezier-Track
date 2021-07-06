using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructClass : MonoBehaviour
{
    public struct PathStruct
    {
        public string path;
    }
    public interface IPathStructInterface
    {
        string path { get; set; }
    }

    public struct PathStructInterface: IPathStructInterface
    {
        private string _path;
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }
    }

    private ArrayList pathStructList = new ArrayList();
    private ArrayList pathStructInterfaceList = new ArrayList();
    private ArrayList pathStructmodifyList = new ArrayList();
    private ArrayList pathStructIntefacemodifyList = new ArrayList();
    void Start()
    {
        PathStruct mps = new PathStruct();
        mps.path = "def";
        pathStructmodifyList.Add(mps);

        PathStructInterface mps2 = new PathStructInterface();
        mps2.path = "def";
        pathStructIntefacemodifyList.Add(mps2);
    }

    void TestStruct()
    {
        PathStruct mps = new PathStruct();
        mps.path = "def";
        pathStructList.Add(mps);
    }

    void TestStructInterface()
    {
        PathStructInterface mps = new PathStructInterface();
        mps.path = "def";
        pathStructInterfaceList.Add(mps);
    }

    void Test_struct_modify()
    {
        PathStruct mst = (PathStruct)pathStructmodifyList[0];
        mst.path = "233244";
        Debug.Log(((PathStruct)pathStructmodifyList[0]).path);

        //pathStructmodifyList[0] = mst;
    }
    void Test_struct_interface_modify()
    {
        IPathStructInterface mst = (IPathStructInterface)pathStructIntefacemodifyList[0];
        mst.path = "123123";
        //pathStructIntefacemodifyList[0] = mst;

        Debug.Log(((IPathStructInterface)pathStructIntefacemodifyList[0]).path);
    }


    // Update is called once per frame
    void Update()
    {
        TestStruct();
        TestStructInterface();
        Test_struct_modify();
        Test_struct_interface_modify();
    }
}
