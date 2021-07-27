using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsJTA 
{
    public static Transform transformHolder;
    // //ขั้น 1
    // public static void SetVector2(string key, Vector2 val)
    // {
    //     string x = key + "V2X";
    //     string y = key + "V2Y";
    //     PlayerPrefs.SetFloat(x, val.x);
    //     PlayerPrefs.SetFloat(y, val.x);
    // }
    // public static Vector2 GetVector2(string key)
    // {
    //     Vector2 val;
    //     string x = key + "V2X";
    //     string y = key + "V2Y";
    //     val.x = PlayerPrefs.GetFloat(x);
    //     val.y = PlayerPrefs.GetFloat(y);
    //     return val;
    // }

    //ขั้น 2
        public static void SetVector3(string key, Vector3 val)
    {
        string x = key + "V3X";
        string y = key + "V3Y";
        string z = key + "V3Z";
        PlayerPrefs.SetFloat(x, val.x);
        PlayerPrefs.SetFloat(y, val.y);
        PlayerPrefs.SetFloat(z, val.z);
    }
    public static Vector3 GetVector3(string key)
    {
        Vector3 val;
        string x = key + "V3X";
        string y = key + "V3Y";
        string z = key + "V3Z";
        val.x = PlayerPrefs.GetFloat(x);
        val.y = PlayerPrefs.GetFloat(y);
        val.z = PlayerPrefs.GetFloat(z);
        return val;
    }

    //ขั้น 3
        public static void SetTransform(string key, Transform val)
    {
        string p = key + "TP";
        string r = key + "TR";
        string s = key + "TS";
        SetVector3(p, val.localPosition);
        SetVector3(r, val.localEulerAngles);
        SetVector3(s, val.localScale);
    }
    public static void GetTransform(string key, Transform val)
    {
        transformHolder = val;
        string p = key + "TP";
        string r = key + "TR";
        string s = key + "TS";
        transformHolder.localPosition = GetVector3(p);
        transformHolder.localEulerAngles = GetVector3(r);
        transformHolder.localScale = GetVector3(s);
        transformHolder = null;
    }
}
