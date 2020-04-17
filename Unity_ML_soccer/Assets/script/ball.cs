using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ///<summary>
    ///足球進門
    /// </summary>
    /// 
    public static bool complete;



    ///<summary>
    ///trigger
    /// </summary>
    /// 
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "得分區")
        {
            complete = true;
        }
    }
}
