using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]  //class นี้จะถูกรียกใช้ โดย Input และ output เพื่อเข้ารหัสข้อมูล 
                //เข้าถึงได้ทุกที่นอกคลาส
public class Player
{
    //*****************ข้อมูลที่ต้องการจะเก็บ*********************
    private string _name ;
    private float _hp ;
    private int _lev;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //สร้าง Constructor ที่ชื่อเหมือนกับ class เพื่อเรียกใช้ได้เฉพาะภายใน class
    //เพื่อที่จะเรียกใช้ได้สองแบบ
    public Player() 
    { 

    }

    public Player(string name , float hp , int lev)   //เวลารับค่าจากข้อมูลของผู้ใช้ เวลาบันทึก 
    {
        _name = name ; //เอาชื่อผู้ใช้ที่บันทึก เอามาเก็บไว้ในตัวแปร _name
        _hp = hp ;     //เอา hp ผู้ใช้ที่บันทึก เอามาเก็บไว้ในตัวแปร _hp
        _lev = lev ;   //เอา lev ผู้ใช้ที่บันทึก เอามาเก็บไว้ในตัวแปร _lev
    }
    

    public string Name {   //ทำการบันทึกชื่อ

        get {               //Loadsave ชื่อ ที่บันทึกไว้
            return _name ;
        }

        set {
            _name = value ;  //save
        }
    }
    public float Health {   //ทำการบันทึกเลือด

        get {               //Loadsave hp ที่บันทึกไว้
            return _hp ;
        }

        set {
            _hp = value ;   //save 
        }
    }
    public int Levels {  //ทำการบันทึกเลเวล

        get {
            return _lev ;   //Loadsave  เลเวล ที่บันทึกไว้
        }

        set {
            _lev = value ;   //save  เลเวล 
        } 
    }

   
}//class



































































